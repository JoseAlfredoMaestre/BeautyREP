using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
    public class SaleStatusRepository : IReadRepository<SaleStatus>
    {
        private DatabaseConnection _dbConnection;

        public SaleStatusRepository()
        {
            _dbConnection = new DatabaseConnection();
        }
        public Response<SaleStatus> GetById(long id)
        {
            try
            {
                _dbConnection.OpenConnection();
                string query = "SELECT Id, Name, CreateAt FROM SaleStatuses WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SaleStatus saleStatus = new SaleStatus(
                                reader.GetInt64(0), // Id
                                reader.GetString(1), // Name
                                reader.GetDateTime(2) // CreateAt
                            );
                            return new ResponseBuilder<SaleStatus>().WithData(saleStatus);
                        }
                        else
                        {
                            return ResponseBuilder<SaleStatus>.Fail("Estado de venta no encontrado");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<SaleStatus>.Error(ex);
            }
            finally
            {
                _dbConnection.CloseConnection();
            }
        }

        public Response<HashSet<SaleStatus>> GetAll()
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = "SELECT Id, Name, CreateAt FROM SaleStatuses";

                HashSet<SaleStatus> saleStatuses = new HashSet<SaleStatus>();

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SaleStatus saleStatus = new SaleStatus(
                                reader.GetInt64(0), // Id
                                reader.GetString(1), // Name
                                reader.GetDateTime(2) // CreateAt
                            );
                            saleStatuses.Add(saleStatus);
                        }
                    }
                }

                _dbConnection.CloseConnection();

                return new ResponseBuilder<HashSet<SaleStatus>>().WithData(saleStatuses).WithSuccess(true);
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<HashSet<SaleStatus>>.Error(ex);
            }
        }


    }
}