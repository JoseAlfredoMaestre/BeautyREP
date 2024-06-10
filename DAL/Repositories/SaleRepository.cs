using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
    public class SaleRepository : IRepository<Sale>
    {
        private readonly DatabaseConnection _dbConnection;

        public SaleRepository()
        {
            _dbConnection = new DatabaseConnection();
        }

        public Response<bool> Insert(Sale sale)
        {
            try
            {
                _dbConnection.OpenConnection();

                // Insert sale location
                var saleLocationQuery =
                    "INSERT INTO SaleLocations (Address, CityId, CreateAt) OUTPUT INSERTED.Id VALUES (@Address, @CityId, @CreateAt);";

                using (var locationCommand = new SqlCommand(saleLocationQuery, _dbConnection.GetConnection()))
                {
                    locationCommand.Parameters.AddWithValue("@Address", sale.Location.Address);
                    locationCommand.Parameters.AddWithValue("@CityId", sale.Location.City.Id);
                    locationCommand.Parameters.AddWithValue("@CreateAt", sale.Location.CreateAt);

                    var locationId = Convert.ToInt64(locationCommand.ExecuteScalar());
                    sale.Location.Id = locationId;
                }

                var query =
                    "INSERT INTO Sales (Discount, CreateAt, LocationsId, StatusId) VALUES (@Discount, @CreateAt, @LocationsId, @StatusId); SELECT SCOPE_IDENTITY();";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Discount", sale.Discount);
                    command.Parameters.AddWithValue("@CreateAt", sale.CreateAt);
                    command.Parameters.AddWithValue("@LocationsId", sale.Location.Id);
                    command.Parameters.AddWithValue("@StatusId", sale.Status.Id);

                    var saleId = Convert.ToInt64(command.ExecuteScalar());

                    // Insert sale details
                    foreach (var saleDetail in sale.SaleDetails)
                    {
                        saleDetail.Sale.Id = saleId;
                        InsertSaleDetail(saleDetail);
                    }
                }

                _dbConnection.CloseConnection();

                return ResponseBuilder<bool>.Success();
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<bool>.Error(ex);
            }
        }


// Método privado para insertar detalles de venta
        private void InsertSaleDetail(SaleDetail saleDetail)
        {
            var query =
                "INSERT INTO SaleDetails (ProductId, Quantity, CreateAt, SaleId) VALUES (@ProductId, @Quantity, @CreateAt, @SaleId)";

            using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@ProductId", saleDetail.Product.Id);
                command.Parameters.AddWithValue("@Quantity", saleDetail.Quantity);
                command.Parameters.AddWithValue("@CreateAt", saleDetail.CreateAt);
                command.Parameters.AddWithValue("@SaleId", saleDetail.Sale.Id);

                command.ExecuteNonQuery();
            }
        }

        public Response<Sale> GetById(long id)
        {
            try
            {
                _dbConnection.OpenConnection();
                var query =
                    "SELECT s.Id, s.Discount, s.CreateAt, s.LocationsId, s.StatusId, l.Address, c.Id, c.Name, c.Description, sts.Id, sts.Name, sts.CreateAt " +
                    "FROM Sales s " +
                    "INNER JOIN SaleLocations l ON s.LocationsId = l.Id " +
                    "INNER JOIN Cities c ON l.CityId = c.Id " +
                    "INNER JOIN SaleStatuses sts ON s.StatusId = sts.Id " +
                    "WHERE s.Id = @Id";
                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var city = new City(
                                reader.GetInt64(6), // City Id
                                reader.GetString(7), // City Name
                                reader.IsDBNull(8) ? null : reader.GetString(8), // City Description
                                reader.GetDateTime(12) // City CreateAt
                            );

                            var saleLocation = new SaleLocation(
                                reader.GetInt64(3), // SaleLocation Id
                                reader.GetString(5), // Address
                                city, // City
                                reader.GetDateTime(2) // CreateAt
                            );

                            var status = new SaleStatus(
                                reader.GetInt64(9), // SaleStatus Id
                                reader.GetString(10), // SaleStatus Name
                                reader.GetDateTime(11) // SaleStatus CreateAt
                            );

                            // Get sale details
                            var saleDetails = GetSaleDetailsBySaleId(id);

                            var sale = new Sale(
                                reader.GetInt64(0), // Sale Id
                                reader.GetInt32(1), // Discount
                                reader.GetDateTime(2), // CreateAt
                                status, // SaleStatus
                                saleDetails, // SaleDetails
                                saleLocation // SaleLocation
                            );

                            return new ResponseBuilder<Sale>().WithData(sale);
                        }
                        else
                        {
                            return ResponseBuilder<Sale>.Fail("Venta no encontrada");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<Sale>.Error(ex);
            }
            finally
            {
                _dbConnection.CloseConnection();
            }
        }

// Método privado para obtener los detalles de venta por el Id de venta
        private HashSet<SaleDetail> GetSaleDetailsBySaleId(long saleId)
        {
            var query =
                "SELECT sd.Id, sd.Quantity, sd.CreateAt, sd.ProductId, p.Name, p.Description, p.UnitPrice, p.Stock, p.Discount " +
                "FROM SaleDetails sd " +
                "INNER JOIN Products p ON sd.ProductId = p.Id " +
                "WHERE sd.SaleId = @SaleId";

            var saleDetails = new HashSet<SaleDetail>();

            using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@SaleId", saleId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product(
                            reader.GetInt64(3), // Product Id
                            reader.GetString(4), // Product Name
                            reader.IsDBNull(5) ? null : reader.GetString(5), // Product Description
                            reader.GetDouble(6), // Product UnitPrice
                            reader.GetInt32(7), // Product Stock
                            reader.GetInt32(8), // Product Discount
                            reader.GetDateTime(2) // Product CreateAt
                        );

                        var saleDetail = new SaleDetail();
                        saleDetail.Id = reader.GetInt64(0); // SaleDetail Id
                        saleDetail.Product = product; // Product
                        saleDetail.Quantity = reader.GetInt32(1); // Quantity
                        saleDetail.CreateAt = reader.GetDateTime(2); // CreateAt
                        saleDetail.Sale.Id = saleId; // Id


                        saleDetails.Add(saleDetail);
                    }
                }
            }

            return saleDetails;
        }

        public Response<HashSet<Sale>> GetAll()
        {
            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT s.Id, s.Discount, s.CreateAt, s.LocationsId, s.StatusId, l.Address, c.Id, c.Name, c.Description, sts.Id, sts.Name, sts.CreateAt " +
                    "FROM Sales s " +
                    "INNER JOIN SaleLocations l ON s.LocationsId = l.Id " +
                    "INNER JOIN Cities c ON l.CityId = c.Id " +
                    "INNER JOIN SaleStatuses sts ON s.StatusId = sts.Id";

                var sales = new HashSet<Sale>();

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var city = new City(
                                reader.GetInt64(6), // City Id
                                reader.GetString(7), // City Name
                                reader.IsDBNull(8) ? null : reader.GetString(8), // City Description
                                reader.GetDateTime(12) // City CreateAt
                            );

                            var saleLocation = new SaleLocation(
                                reader.GetInt64(3), // SaleLocation Id
                                reader.GetString(5), // Address
                                city, //
                                reader.GetDateTime(2) // CreateAt
                            );

                            var status = new SaleStatus(
                                reader.GetInt64(9), // SaleStatus Id
                                reader.GetString(10), // SaleStatus Name
                                reader.GetDateTime(11) // SaleStatus CreateAt
                            );

                            // Get sale details
                            var saleDetails = GetSaleDetailsBySaleId(reader.GetInt64(0)); // Sale Id

                            var sale = new Sale(
                                reader.GetInt64(0), // Sale Id
                                reader.GetInt32(1), // Discount
                                reader.GetDateTime(2), // CreateAt
                                status, // SaleStatus
                                saleDetails, // SaleDetails
                                saleLocation // SaleLocation
                            );

                            sales.Add(sale);
                        }
                    }
                }

                _dbConnection.CloseConnection();

                return new ResponseBuilder<HashSet<Sale>>().WithData(sales).WithSuccess(true);
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<HashSet<Sale>>.Error(ex);
            }
        }

        public Response<bool> Update(Sale sale)
        {
            try
            {
                _dbConnection.OpenConnection();

                var query = @"UPDATE Sales 
                         SET Discount = @Discount,
                             CreateAt = @CreateAt,
                             LocationsId = @LocationsId,
                             StatusId = @StatusId
                         WHERE Id = @Id";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", sale.Id);
                    command.Parameters.AddWithValue("@Discount", sale.Discount);
                    command.Parameters.AddWithValue("@CreateAt", sale.CreateAt);
                    command.Parameters.AddWithValue("@LocationsId", sale.Location.Id);
                    command.Parameters.AddWithValue("@StatusId", sale.Status.Id);

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return new ResponseBuilder<bool>().WithData(true);
                    else
                        return ResponseBuilder<bool>.Fail("No se ha modificado la venta");
                }
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<bool>.Error(ex);
            }
            finally
            {
                _dbConnection.CloseConnection();
            }
        }

        public Response<bool> Delete(long id)
        {
            try
            {
                _dbConnection.OpenConnection();

                var query = "DELETE FROM Sales WHERE Id = @Id";
                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return new ResponseBuilder<bool>().WithData(true);
                    else
                        return ResponseBuilder<bool>.Fail("No se ha eliminado la venta");
                }
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<bool>.Error(ex);
            }
            finally
            {
                _dbConnection.CloseConnection();
            }
        }
    }
}