using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
    public class UserRepository : IRepository<User>
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
            string query = "SELECT Id, IdentityCard, Names, Surnames, Phone, Email, CreateAt FROM Users WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User(
                            reader.GetInt64(0), // Id
                            reader.GetString(1), // IdentityCard
                            reader.GetString(2), // Names
                            reader.GetString(3), // Surnames
                            reader.GetString(4), // Phone
                            reader.GetString(5), // Email
                            reader.GetDateTime(6)  // CreateAt
                        );
                        return new ResponseBuilder<User>().WithData(user);
                    }
                    else
                    {
                        return ResponseBuilder<User>.Fail("Usuario no encontrado");
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            return ResponseBuilder<User>.Error(ex);
        }
        finally
        {
            _dbConnection.CloseConnection();
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
                        user.Surnames = reader.GetString(2);
                        user.Phone = reader.GetString(3);
                        user.Email = reader.GetString(4);
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

            string query = @"UPDATE Users 
                         SET IdentityCard = @IdentityCard,
                             Names = @Names,
                             Surnames = @Surnames,
                             Phone = @Phone,
                             Email = @Email,
                             Username = @Username,
                             Password = @Password,
                             CreateAt = @CreateAt
                         WHERE Id = @Id";

            using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@Id", user.Id);
                command.Parameters.AddWithValue("@IdentityCard", user.IdentityCard);
                command.Parameters.AddWithValue("@Names", user.Names);
                command.Parameters.AddWithValue("@Surnames", user.Surnames);
                command.Parameters.AddWithValue("@Phone", user.Phone);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Username", user.Username ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Password", user.Password ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CreateAt", user.CreateAt);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return new ResponseBuilder<bool>().WithData(true);
                }
                else
                {
                    return ResponseBuilder<bool>.Fail("No se ha modificado el usuario");
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

            string query = "DELETE FROM Users WHERE Id = @Id";
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
                    return ResponseBuilder<bool>.Fail("No se han eliminado usuarios");
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