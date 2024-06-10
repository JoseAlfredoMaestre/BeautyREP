using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Models;
using Entities.Shared;

namespace DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {

        private DatabaseConnection _dbConnection;

        public ProductRepository()
        {
            _dbConnection = new DatabaseConnection();
        }
        public Response<bool> Insert(Product product)
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = "INSERT INTO Products (Name, Description, UnitPrice, Stock, Discount, CreateAt) VALUES (@Name, @Description, @UnitPrice, @Stock, @Discount, @CreateAt)";

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Description", product.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.Parameters.AddWithValue("@Discount", product.Discount);
                    command.Parameters.AddWithValue("@CreateAt", product.CreateAt);

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
        public Response<Product> GetById(long id)
        {
            try
            {
                _dbConnection.OpenConnection();
                string query = "SELECT Id, Name, Description, UnitPrice, Stock, Discount, CreateAt FROM Products WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Product product = new Product(
                                reader.GetInt64(0), // Id
                                reader.GetString(1), // Name
                                reader.IsDBNull(2) ? null : reader.GetString(2), // Description
                                reader.GetDouble(3), // UnitPrice
                                reader.GetInt32(4), // Stock
                                reader.GetInt32(5), // Discount
                                reader.GetDateTime(6)  // CreateAt
                            );
                            return new ResponseBuilder<Product>().WithData(product);
                        }
                        else
                        {
                            return ResponseBuilder<Product>.Fail("Producto no encontrado");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<Product>.Error(ex);
            }
            finally
            {
                _dbConnection.CloseConnection();
            }
        }
        public Response<HashSet<Product>> GetAll()
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = "SELECT Id, Name, Description, UnitPrice, Stock, Discount, CreateAt FROM Products";

                HashSet<Product> products = new HashSet<Product>();

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product(
                                reader.GetInt64(0), // Id
                                reader.GetString(1), // Name
                                reader.IsDBNull(2) ? null : reader.GetString(2), // Description
                                reader.GetDouble(3), // UnitPrice
                                reader.GetInt32(4), // Stock
                                reader.GetInt32(5), // Discount
                                reader.GetDateTime(6)  // CreateAt
                            );
                            products.Add(product);
                        }
                    }
                }

                _dbConnection.CloseConnection();

                return new ResponseBuilder<HashSet<Product>>().WithData(products).WithSuccess(true);
            }
            catch (SqlException ex)
            {
                return ResponseBuilder<HashSet<Product>>.Error(ex);
            }
        }
        public Response<bool> Update(Product product)
        {
            try
            {
                _dbConnection.OpenConnection();

                string query = @"UPDATE Products 
                         SET Name = @Name,
                             Description = @Description,
                             UnitPrice = @UnitPrice,
                             Stock = @Stock,
                             Discount = @Discount,
                             CreateAt = @CreateAt
                         WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Description", product.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.Parameters.AddWithValue("@Discount", product.Discount);
                    command.Parameters.AddWithValue("@CreateAt", product.CreateAt);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return new ResponseBuilder<bool>().WithData(true);
                    }
                    else
                    {
                        return ResponseBuilder<bool>.Fail("No se ha modificado el producto");
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

                string query = "DELETE FROM Products WHERE Id = @Id";
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
                        return ResponseBuilder<bool>.Fail("No se han eliminado productos");
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