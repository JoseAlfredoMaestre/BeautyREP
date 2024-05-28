using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
    public class UserRepository
{
    private DatabaseConnection _dbConnection;

    public UserRepository()
    {
        _dbConnection = new DatabaseConnection();
    }

    public Response<bool> Insert(User user)
    {
        try
        {
            _dbConnection.OpenConnection();

            string query = "INSERT INTO Users (IdentityCard, Names, Surnames, Phone, Email, Username, Password, CreateAt, Role) VALUES (@IdentityCard, @Names, @Surnames, @Phone, @Email, @Username, @Password, @CreateAt, @Role)";

            using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@IdentityCard", user.IdentityCard);
                command.Parameters.AddWithValue("@Names", user.Names);
                command.Parameters.AddWithValue("@Surnames", user.Surnames);
                command.Parameters.AddWithValue("@Phone", user.Phone);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Username", user.Username ?? (object)DBNull.Value); // Si 'Username' es null, insertamos DBNull.Value en la base de datos.
                command.Parameters.AddWithValue("@Password", user.Password ?? (object)DBNull.Value); // Si 'Password' es null, insertamos DBNull.Value en la base de datos.
                command.Parameters.AddWithValue("@CreateAt", user.CreateAt);
                command.Parameters.AddWithValue("@Role", user.Role);

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

    public Response<User> GetById(long id)
    {
        try
        {
            _dbConnection.OpenConnection();

            // Aquí iría el código para leer el usuario de la base de datos.
            // Por ejemplo, podrías usar un SqlCommand para ejecutar una sentencia SELECT.

            _dbConnection.CloseConnection();

            // Deberías retornar el usuario leído de la base de datos.
            // He puesto null como valor por defecto porque este es solo un ejemplo.
            return ResponseBuilder<User>.Success(null);
        }
        catch (SqlException ex)
        {
            return ResponseBuilder<User>.Error(ex);
        }
    }
    public Response<HashSet<User>> GetAll()
    {
        try
        {
            _dbConnection.OpenConnection();

            string query = "SELECT * FROM Users";

            HashSet<User> users = new HashSet<User>();

            using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = reader.GetInt64(0);
                        user.Names = reader.GetString(1);
                        user.Surnames = reader.IsDBNull(2) ? null : reader.GetString(2);
                        user.Phone = reader.GetString(3);
                        user.Email = reader.GetString(4);
                        user.Username = reader.IsDBNull(5) ? null : reader.GetString(5);
                        user.Password = reader.IsDBNull(6) ? null : reader.GetString(6);
                        user.CreateAt = reader.GetDateTime(7);
                        users.Add(user);
                    }
                }
            }

            _dbConnection.CloseConnection();

            return new ResponseBuilder<HashSet<User>>().WithData(users).WithSuccess(true);
        }
        catch (SqlException ex)
        {
            return ResponseBuilder<HashSet<User>>.Error(ex);
        }
    }

    public Response<bool> Update(User user)
    {
        try
        {
            _dbConnection.OpenConnection();

            // Aquí iría el código para actualizar el usuario en la base de datos.
            // Por ejemplo, podrías usar un SqlCommand para ejecutar una sentencia UPDATE.

            _dbConnection.CloseConnection();

            return ResponseBuilder<bool>.Success();
        }
        catch (SqlException ex)
        {
            return ResponseBuilder<bool>.Error(ex);
        }
    }

    public Response<bool> Delete(long id)
    {
        try
        {
            _dbConnection.OpenConnection();

            // Aquí iría el código para eliminar el usuario de la base de datos.
            // Por ejemplo, podrías usar un SqlCommand para ejecutar una sentencia DELETE.

            _dbConnection.CloseConnection();

            return ResponseBuilder<bool>.Success();
        }
        catch (SqlException ex)
        {
            return ResponseBuilder<bool>.Error(ex);
        }
    }
}

}