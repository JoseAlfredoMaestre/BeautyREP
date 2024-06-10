using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
    public class CityRepository : IRepository<City>
    {
        private DatabaseConnection _dbConnection;

        public CityRepository()
        {
            _dbConnection = new DatabaseConnection();
        }
        public Response<bool> Insert(City city)
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = "INSERT INTO Cities (Name, Description, CreateAt) VALUES (@Name, @Description, @CreateAt)";

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Name", city.Name);
                    command.Parameters.AddWithValue("@Description", city.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreateAt", city.CreateAt);

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

        public Response<City> GetById(long id)
        {
            try
            {
                _dbConnection.OpenConnection();
                string query = "SELECT Id, Name, Description, CreateAt FROM Cities WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            City city = new City(
                                reader.GetInt64(0), // Id
                                reader.GetString(1), // Name
                                reader.IsDBNull(2) ? null : reader.GetString(2), // Description
                                reader.GetDateTime(3)  // CreateAt
                            );
                            return new ResponseBuilder<City>().WithData(city);
                        }
                        else
                        {
                            return ResponseBuilder<City>.Fail("Ciudad no encontrada");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<City>.Error(ex);
            }
            finally
            {
                _dbConnection.CloseConnection();
            }
        }
        public Response<HashSet<City>> GetAll()
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = "SELECT Id, Name, Description, CreateAt FROM Cities";

                HashSet<City> cities = new HashSet<City>();

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            City city = new City(
                                reader.GetInt64(0), // Id
                                reader.GetString(1), // Name
                                reader.IsDBNull(2) ? null : reader.GetString(2), // Description
                                reader.GetDateTime(3)  // CreateAt
                            );
                            cities.Add(city);
                        }
                    }
                }

                _dbConnection.CloseConnection();

                return new ResponseBuilder<HashSet<City>>().WithData(cities).WithSuccess(true);
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<HashSet<City>>.Error(ex);
            }
        }
        public Response<bool> Update(City city)
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = @"UPDATE Cities 
                         SET Name = @Name,
                             Description = @Description,
                             CreateAt = @CreateAt
                         WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", city.Id);
                    command.Parameters.AddWithValue("@Name", city.Name);
                    command.Parameters.AddWithValue("@Description", city.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreateAt", city.CreateAt);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return new ResponseBuilder<bool>().WithData(true);
                    }
                    else
                    {
                        return ResponseBuilder<bool>.Fail("No se ha modificado la ciudad");
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

                string query = "DELETE FROM Cities WHERE Id = @Id";
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
                        return ResponseBuilder<bool>.Fail("No se han eliminado ciudades");
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