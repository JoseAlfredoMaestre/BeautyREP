using Entities.Shared;

namespace DAL.Connection
{
    using System.Data.SqlClient;

    public class DatabaseConnection
    {
        private SqlConnection _connection;
        private static DatabaseConnection _instance;
        public DatabaseConnection()
        {
            const string connectionString = "workstation id=beautydb.mssql.somee.com;packet size=4096;user id=Alfredo_SQLLogin_1;pwd=nv7ygbo9kk;data source=beautydb.mssql.somee.com;persist security info=False;initial catalog=beautydb;TrustServerCertificate=True";
            _connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public static DatabaseConnection Instance()
        {
            return _instance ?? new DatabaseConnection();
        }

        public Response<bool> OpenConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed) _connection.Open();
                return ResponseBuilder<bool>.Success();
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<bool>.Error(ex);
            }
        }

        public Response<bool> CloseConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Open) _connection.Close();
                return ResponseBuilder<bool>.Success();
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<bool>.Error(ex);

            }
        }
    }


}