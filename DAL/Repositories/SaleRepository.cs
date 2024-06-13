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

                // Insertar SaleLocation antes de insertar Sale
                string querySaleLocation = "INSERT INTO SaleLocations (Address, CityId, CreateAt) OUTPUT INSERTED.Id VALUES (@Address, @CityId, @CreateAt)";
                using (SqlCommand command = new SqlCommand(querySaleLocation, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Address", sale.Location.Address);
                    command.Parameters.AddWithValue("@CityId", sale.Location.City.Id);
                    command.Parameters.AddWithValue("@CreateAt", sale.Location.CreateAt);

                    // Obtener el ID del SaleLocation insertado
                    var locationId = (long)command.ExecuteScalar();
                    sale.Location.Id = locationId;
                }

                var querySale =
                    "INSERT INTO Sales (Discount, CreateAt, LocationsId, UserId) VALUES (@Discount, @CreateAt, @LocationsId, @UserId); SELECT SCOPE_IDENTITY();";

                using (var command = new SqlCommand(querySale, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Discount", sale.Discount);
                    command.Parameters.AddWithValue("@CreateAt", sale.CreateAt);
                    command.Parameters.AddWithValue("@LocationsId", sale.Location.Id);
                    command.Parameters.AddWithValue("@UserId", sale.User.Id);

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

        public Response<Sale> GetById(long id)
        {
            try
            {
                _dbConnection.OpenConnection();
                var query =
                    "SELECT s.Id, s.Discount, s.CreateAt, s.LocationsId, s.StatusId, l.Address, c.Id, c.Name, c.Description, sts.Id, sts.Name, sts.CreateAt, c.CreateAt, " +
                    "us.Id, us.IdentityCard, us.Names, us.Surnames, us.Phone, us.Email, us.CreateAt, l.CreateAt " +
                    "FROM Sales s " +
                    "INNER JOIN SaleLocations l ON s.LocationsId = l.Id " +
                    "INNER JOIN Cities c ON l.CityId = c.Id " +
                    "INNER JOIN SaleStatuses sts ON s.StatusId = sts.Id " +
                    "INNER JOIN Users us ON s.UserId = us.Id " +
                    "WHERE s.Id = @Id";
                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    Sale sale;
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return ResponseBuilder<Sale>.Fail("Venta no encontrada");
                        }
                        else
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
                                reader.GetDateTime(20) // CreateAt
                            );

                            var status = new SaleStatus(
                                reader.GetInt64(9), // SaleStatus Id
                                reader.GetString(10), // SaleStatus Name
                                reader.GetDateTime(11) // SaleStatus CreateAt
                            );
                            var user = new User(
                                reader.GetInt64(13), // Id
                                reader.GetString(14), // IdentityCard
                                reader.GetString(15), // Names
                                reader.GetString(16), // Surnames
                                reader.GetString(17), // Phone
                                reader.GetString(18), // Email
                                reader.GetDateTime(19) // CreateAt
                            );

                            sale = new Sale(
                                reader.GetInt64(0), // Sale Id
                                reader.GetInt32(1), // Discount
                                reader.GetDateTime(2), // CreateAt
                                status, // SaleStatus
                                new HashSet<SaleDetail>(), // SaleDetails
                                saleLocation, // SaleLocation
                                user // User
                            );

                        }
                    }
                    sale.SaleDetails = GetSaleDetailsBySaleId(sale.Id);
                    return new ResponseBuilder<Sale>().WithData(sale).WithSuccess();
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

        public Response<HashSet<Sale>> GetAll()
        {
            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT s.Id, s.Discount, s.CreateAt, s.LocationsId, s.StatusId, l.Address, c.Id, c.Name, c.Description, sts.Id, sts.Name, sts.CreateAt, c.CreateAt, " +
                    "us.Id, us.IdentityCard, us.Names, us.Surnames, us.Phone, us.Email, us.CreateAt, l.CreateAt " +
                    "FROM Sales s " +
                    "INNER JOIN SaleLocations l ON s.LocationsId = l.Id " +
                    "INNER JOIN Cities c ON l.CityId = c.Id " +
                    "INNER JOIN SaleStatuses sts ON s.StatusId = sts.Id " +
                    "INNER JOIN Users us ON s.UserId = us.Id ";

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
                                reader.GetDateTime(20) // CreateAt
                            );

                            var status = new SaleStatus(
                                reader.GetInt64(9), // SaleStatus Id
                                reader.GetString(10), // SaleStatus Name
                                reader.GetDateTime(11) // SaleStatus CreateAt
                            );
                            var user = new User(
                                reader.GetInt64(13), // Id
                                reader.GetString(14), // IdentityCard
                                reader.GetString(15), // Names
                                reader.GetString(16), // Surnames
                                reader.GetString(17), // Phone
                                reader.GetString(18), // Email
                                reader.GetDateTime(19) // CreateAt
                            );

                            var sale = new Sale(
                                reader.GetInt64(0), // Sale Id
                                reader.GetInt32(1), // Discount
                                reader.GetDateTime(2), // CreateAt
                                status, // SaleStatus
                                new HashSet<SaleDetail>(), // SaleDetails
                                saleLocation, // SaleLocation
                                user // User
                            );

                            sales.Add(sale);
                        }
                    }
                }

                // Get sale details for each sale
                foreach (var sale in sales) sale.SaleDetails = GetSaleDetailsBySaleId(sale.Id);

                _dbConnection.CloseConnection();

                return new ResponseBuilder<HashSet<Sale>>().WithData(sales);
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
    }
}