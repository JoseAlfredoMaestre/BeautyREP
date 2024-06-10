using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
    public class SaleLocationRepository : IRepository<SaleLocation>
    {
        private DatabaseConnection _dbConnection;

        public SaleLocationRepository()
        {
            _dbConnection = new DatabaseConnection();
        }

        public Response<bool> Insert(SaleLocation saleLocation)
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = "INSERT INTO SaleLocations (Address, CityId, CreateAt) VALUES (@Address, @CityId, @CreateAt)";

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Address", saleLocation.Address);
                    command.Parameters.AddWithValue("@CityId", saleLocation.City.Id);
                    command.Parameters.AddWithValue("@CreateAt", saleLocation.CreateAt);

                    command.ExecuteNonQuery();
                }

                _dbConnection.CloseConnection();

                return ResponseBuilder<bool>.Success();
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<bool>.Error(ex);
            }
        }
        public Response<SaleLocation> GetById(long id)
        {
            try
            {
                _dbConnection.OpenConnection();
                string query = "SELECT sl.Id, sl.Address, sl.CityId, sl.CreateAt, c.Id, c.Name, c.Description, c.CreateAt FROM SaleLocations sl INNER JOIN Cities c ON sl.CityId = c.Id WHERE sl.Id = @Id";
                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            City city = new City(
                                reader.GetInt64(4), // City Id
                                reader.GetString(5), // City Name
                                reader.IsDBNull(6) ? null : reader.GetString(6), // City Description
                                reader.GetDateTime(7)  // City CreateAt
                            );

                            SaleLocation saleLocation = new SaleLocation(
                                reader.GetInt64(0), // SaleLocation Id
                                reader.GetString(1), // Address
                                city, // City
                                reader.GetDateTime(3) // CreateAt
                            );
                            return new ResponseBuilder<SaleLocation>().WithData(saleLocation);
                        }
                        else
                        {
                            return ResponseBuilder<SaleLocation>.Fail("Ubicación de venta no encontrada");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<SaleLocation>.Error(ex);
            }
            finally
            {
                _dbConnection.CloseConnection();
            }
        }
        public Response<HashSet<SaleLocation>> GetAll()
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = "SELECT sl.Id, sl.Address, sl.CityId, sl.CreateAt, c.Id, c.Name, c.Description, c.CreateAt FROM SaleLocations sl INNER JOIN Cities c ON sl.CityId = c.Id";

                HashSet<SaleLocation> saleLocations = new HashSet<SaleLocation>();

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            City city = new City(
                                reader.GetInt64(4), // City Id
                                reader.GetString(5), // City Name
                                reader.IsDBNull(6) ? null : reader.GetString(6), // City Description
                                reader.GetDateTime(7)  // City CreateAt
                            );

                            SaleLocation saleLocation = new SaleLocation(
                                reader.GetInt64(0), // SaleLocation Id
                                reader.GetString(1), // Address
                                city, // City
                                reader.GetDateTime(3) // CreateAt
                            );
                            saleLocations.Add(saleLocation);
                        }
                    }
                }

                _dbConnection.CloseConnection();

                return new ResponseBuilder<HashSet<SaleLocation>>().WithData(saleLocations).WithSuccess(true);
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<HashSet<SaleLocation>>.Error(ex);
            }
        }
        public Response<bool> Update(SaleLocation saleLocation)
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = @"UPDATE SaleLocations 
                         SET Address = @Address,
                             CityId = @CityId,
                             CreateAt = @CreateAt
                         WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", saleLocation.Id);
                    command.Parameters.AddWithValue("@Address", saleLocation.Address);
                    command.Parameters.AddWithValue("@CityId", saleLocation.City.Id);
                    command.Parameters.AddWithValue("@CreateAt", saleLocation.CreateAt);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return new ResponseBuilder<bool>().WithData(true);
                    }
                    else
                    {
                        return ResponseBuilder<bool>.Fail("No se ha modificado la ubicación de venta");
                    }
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

                string query = "DELETE FROM SaleLocations WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return new ResponseBuilder<bool>().WithData(true);
                    }
                    else
                    {
                        return ResponseBuilder<bool>.Fail("No se han eliminado ubicaciones de venta");
                    }
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