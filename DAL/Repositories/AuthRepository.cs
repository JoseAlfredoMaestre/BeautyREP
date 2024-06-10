using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
   public class AuthRepository : IAuthRepository
{
    private DatabaseConnection _dbConnection;

    public AuthRepository()
    {
        _dbConnection = new DatabaseConnection();
    }

    public Response<Person> Authenticate(Person person)
{
    try
    {
        _dbConnection.OpenConnection();
        string query = "SELECT Id, IdentityCard, Names, Surnames, Phone, Email, Username, Password, CreateAt FROM Admins WHERE Username = @Username AND Password = @Password";
        using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
        {
            command.Parameters.AddWithValue("@Username", person.Username);
            command.Parameters.AddWithValue("@Password", person.Password);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Se encontró un administrador con las credenciales proporcionadas
                    Admin authenticatedAdmin = new Admin(
                        reader.GetInt64(0), // Id
                        reader.GetString(1), // IdentityCard
                        reader.GetString(2), // Names
                        reader.GetString(3), // Surnames
                        reader.GetString(4), // Phone
                        reader.GetString(5), // Email
                        reader.IsDBNull(6) ? null : reader.GetString(6), // Username
                        reader.IsDBNull(7) ? null : reader.GetString(7), // Password
                        reader.GetDateTime(8)  // CreateA
                    );
                    return new ResponseBuilder<Person>().WithData(authenticatedAdmin).WithSuccess(true);
                }
            }
        }

        // Si no se encontró un administrador, buscamos en la tabla de usuarios
        query = "SELECT Id, IdentityCard, Names, Surnames, Phone, Email, Username, Password, CreateAt FROM Users WHERE Username = @Username AND Password = @Password";
        using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
        {
            command.Parameters.AddWithValue("@Username", person.Username);
            command.Parameters.AddWithValue("@Password", person.Password);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Se encontró un usuario con las credenciales proporcionadas
                    User authenticatedUser = new User(
                        reader.GetInt64(0), // Id
                        reader.GetString(2), // IdentityCard
                        reader.GetString(1), // Names
                        reader.GetString(3), // Surnames
                        reader.GetString(4), // Phone
                        reader.GetString(5), // Email
                        reader.IsDBNull(6) ? null : reader.GetString(6), // Username
                        reader.IsDBNull(7) ? null : reader.GetString(7), // Password
                        reader.GetDateTime(8)  // CreateAt
                    );
                    return new ResponseBuilder<Person>().WithData(authenticatedUser).WithSuccess(true);
                }
            }
        }
        return ResponseBuilder<Person>.Fail("Credenciales inválidas");
    }
    catch (SqlException ex)
    {
        return ResponseBuilder<Person>.Error(ex);
    }
    finally
    {
        _dbConnection.CloseConnection();
    }
}

}

}