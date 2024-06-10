using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Connection;
using Entities.Shared;

namespace DAL.Repositories
{
    public class StatsRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public StatsRepository()
        {
            _dbConnection = new DatabaseConnection();
        }

        // (El dictionary es un map)

        // Obtiene el valor de las ventas de todos los meses en un año en especifico, por default el año es el actual. Dictionary<Nombre del mes (string), valor de las ventas (double)>
        public Response<Dictionary<string, double>> GetMonthlySales(int? year = null)
        {
            var salesStatistics = new Dictionary<string, double>();
            year = year ?? DateTime.Now.Year;

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT FORMAT(Sales.CreateAt, 'yyyy-MM') as Month, SUM(SaleDetails.Quantity * (Products.UnitPrice - Products.UnitPrice * Products.Discount / 100)) as TotalSales FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id WHERE YEAR(Sales.CreateAt) = @Year GROUP BY FORMAT(Sales.CreateAt, 'yyyy-MM')";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Year", year);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var month = reader.GetString(0);
                            var totalSales = reader.GetDouble(1);

                            salesStatistics[month] = totalSales;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, double>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, double>>().WithSuccess().WithData(salesStatistics);
        }


        // Obtiene el valor de las ventas de todos los años, <Año (int), valor de las ventas (double)>
        public Response<Dictionary<int, double>> GetAnnualSales()
        {
            var salesStatistics = new Dictionary<int, double>();

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT YEAR(Sales.CreateAt) as Year, SUM(SaleDetails.Quantity * (Products.UnitPrice - Products.UnitPrice * Products.Discount / 100)) as TotalSales FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id GROUP BY YEAR(Sales.CreateAt)";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var year = reader.GetInt32(0);
                            var totalSales = reader.GetDouble(1);

                            salesStatistics[year] = totalSales;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<int, double>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<int, double>>().WithSuccess().WithData(salesStatistics);
        }


        // Obtiene la cantidad de ventas de todos los meses en un año en especifico, por default el año es el actual. Dictionary<Nombre del mes (string), cantidad de ventas (int)>
        public Response<Dictionary<string, int>> GetMonthlySalesCount(int? year = null)
        {
            var salesCount = new Dictionary<string, int>();
            year = year ?? DateTime.Now.Year;
            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT FORMAT(Sales.CreateAt, 'yyyy-MM') as Month, COUNT(*) as SalesCount FROM Sales WHERE YEAR(Sales.CreateAt) = @Year GROUP BY FORMAT(Sales.CreateAt, 'yyyy-MM')";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Year", year);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var month = reader.GetString(0);
                            var count = reader.GetInt32(1);

                            salesCount[month] = count;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, int>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, int>>().WithSuccess().WithData(salesCount);
        }


        // Obtiene la cantidad de ventas de todos los años. Dictionary<Año (int), cantidad de ventas (int)>
        public Response<Dictionary<int, int>> GetAnnualSalesCount()
        {
            var salesCount = new Dictionary<int, int>();

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT YEAR(Sales.CreateAt) as Year, COUNT(*) as SalesCount FROM Sales GROUP BY YEAR(Sales.CreateAt)";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var year = reader.GetInt32(0);
                            var count = reader.GetInt32(1);

                            salesCount[year] = count;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<int, int>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<int, int>>().WithSuccess().WithData(salesCount);
        }


        // Obtiene la cantidad de usuarios registrados de todos los meses en un año en especifico, por default el año es el actual. Dictionary<Nombre del mes (string), cantidad de usuarios (int)>
        public Response<Dictionary<string, int>> GetMonthlyUserCreated(int? year = null)
        {
            var userCreationStatistics = new Dictionary<string, int>();
            year = year ?? DateTime.Now.Year;
            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT FORMAT(Users.CreateAt, 'yyyy-MM') as Month, COUNT(*) as UserCount FROM Users WHERE YEAR(Users.CreateAt) = @Year GROUP BY FORMAT(Users.CreateAt, 'yyyy-MM')";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Year", year);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var month = reader.GetString(0);
                            var count = reader.GetInt32(1);

                            userCreationStatistics[month] = count;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, int>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, int>>().WithSuccess().WithData(userCreationStatistics);
        }


        // Obtiene la cantidad de usuarios registrados de todos los años. Dictionary<Año (int), cantidad de usuarios (int)>
        public Response<Dictionary<int, int>> GetAnnualUserCreated()
        {
            var userCreationStatistics = new Dictionary<int, int>();

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT YEAR(Users.CreateAt) as Year, COUNT(*) as UserCount FROM Users GROUP BY YEAR(Users.CreateAt)";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var year = reader.GetInt32(0);
                            var count = reader.GetInt32(1);

                            userCreationStatistics[year] = count;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<int, int>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<int, int>>().WithSuccess().WithData(userCreationStatistics);
        }


        // Obtiene la cantidad de ventas por cada producto en un dia en especifico, por default el dia es el actual. Dictionary<Nombre del producto (string), cantidad de ventas (int)>
        public Response<Dictionary<string, int>> GetDailyProductSales(DateTime? day = null)
        {
            var productSalesStatistics = new Dictionary<string, int>();
            var targetDay = day ?? DateTime.Now;

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT Products.Name, SUM(SaleDetails.Quantity) as SalesCount FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id WHERE CAST(Sales.CreateAt AS DATE) = @Day GROUP BY Products.Name";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Day", targetDay);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productName = reader.GetString(0);
                            var salesCount = reader.GetInt32(1);

                            productSalesStatistics[productName] = salesCount;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, int>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, int>>().WithSuccess().WithData(productSalesStatistics);
        }


        // Obtiene la cantidad de ventas por cada producto en un mes en especifico, por default el mes es el actual y se peude especificar de que año es ese mes, por default el año es el actual.
        // Dictionary<Nombre del producto (string), cantidad de ventas (int)>
        public Response<Dictionary<string, int>> GetMonthlyProductSales(int? month = null, int? year = null)
        {
            var productSalesStatistics = new Dictionary<string, int>();
            var targetYear = year ?? DateTime.Now.Year;
            var targetMonth = month ?? DateTime.Now.Month;

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT Products.Name, SUM(SaleDetails.Quantity) as SalesCount FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id WHERE YEAR(Sales.CreateAt) = @Year AND MONTH(Sales.CreateAt) = @Month GROUP BY Products.Name";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Year", targetYear);
                    command.Parameters.AddWithValue("@Month", targetMonth);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productName = reader.GetString(0);
                            var salesCount = reader.GetInt32(1);

                            productSalesStatistics[productName] = salesCount;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, int>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, int>>().WithSuccess().WithData(productSalesStatistics);
        }


        // Obtiene la cantidad de ventas por cada producto en un año en especifico, por default el año es el actual. Dictionary<Nombre del producto (string), cantidad de ventas (int)>
        public Response<Dictionary<string, int>> GetAnnualProductSales(int? year = null)
        {
            var productSalesStatistics = new Dictionary<string, int>();
            var targetYear = year ?? DateTime.Now.Year;

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT Products.Name, SUM(SaleDetails.Quantity) as SalesCount FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id WHERE YEAR(Sales.CreateAt) = @Year GROUP BY Products.Name";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Year", targetYear);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productName = reader.GetString(0);
                            var salesCount = reader.GetInt32(1);

                            productSalesStatistics[productName] = salesCount;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, int>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, int>>().WithSuccess().WithData(productSalesStatistics);
        }


        // Obtiene el valor de las ventas por cada producto en un dia en especifico, por default el año es el actual. Dictionary<Nombre del producto (string), valor de las ventas (double)>
        public Response<Dictionary<string, double>> GetDailyProductSalesValue(DateTime? day = null)
        {
            var productSalesStatistics = new Dictionary<string, double>();
            var targetDay = day ?? DateTime.Now;

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT Products.Name, SUM(SaleDetails.Quantity * (Products.UnitPrice - Products.UnitPrice * Products.Discount / 100)) as SalesValue FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id WHERE CAST(Sales.CreateAt AS DATE) = @Day GROUP BY Products.Name";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Day", targetDay);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productName = reader.GetString(0);
                            var salesValue = reader.GetDouble(1);

                            productSalesStatistics[productName] = salesValue;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, double>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, double>>().WithSuccess().WithData(productSalesStatistics);
        }


        // Obtiene el valor de las ventas por cada producto en un mes en especifico, por default el mes es el actual y se peude especificar de que año es ese mes, por default el año es el actual.
        // Dictionary<Nombre del producto (string), valor de las ventas (double)>
        public Response<Dictionary<string, double>> GetMonthlyProductSalesValue(int? month = null, int? year = null)
        {
            var productSalesStatistics = new Dictionary<string, double>();
            var targetYear = year ?? DateTime.Now.Year;
            var targetMonth = month ?? DateTime.Now.Month;

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT Products.Name, SUM(SaleDetails.Quantity * (Products.UnitPrice - Products.UnitPrice * Products.Discount / 100)) as SalesValue FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id WHERE YEAR(Sales.CreateAt) = @Year AND MONTH(Sales.CreateAt) = @Month GROUP BY Products.Name";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Year", targetYear);
                    command.Parameters.AddWithValue("@Month", targetMonth);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productName = reader.GetString(0);
                            var salesValue = reader.GetDouble(1);

                            productSalesStatistics[productName] = salesValue;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, double>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, double>>().WithSuccess().WithData(productSalesStatistics);
        }


        // Obtiene el valor de las ventas por cada producto en un año en especifico, por default el año es el actual. Dictionary<Nombre del producto (string), valor de las ventas (double)>
        public Response<Dictionary<string, double>> GetAnnualProductSalesValue(int? year = null)
        {
            var productSalesStatistics = new Dictionary<string, double>();
            var targetYear = year ?? DateTime.Now.Year;

            try
            {
                _dbConnection.OpenConnection();

                var query =
                    "SELECT Products.Name, SUM(SaleDetails.Quantity * (Products.UnitPrice - Products.UnitPrice * Products.Discount / 100)) as SalesValue FROM Sales INNER JOIN SaleDetails ON Sales.Id = SaleDetails.SaleId INNER JOIN Products ON SaleDetails.ProductId = Products.Id WHERE YEAR(Sales.CreateAt) = @Year GROUP BY Products.Name";

                using (var command = new SqlCommand(query, _dbConnection.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Year", targetYear);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productName = reader.GetString(0);
                            var salesValue = reader.GetDouble(1);

                            productSalesStatistics[productName] = salesValue;
                        }
                    }
                }

                _dbConnection.CloseConnection();
            }
            catch (SqlException ex)
            {
                // Handle exception
                return ResponseBuilder<Dictionary<string, double>>.Error(ex);
            }

            return new ResponseBuilder<Dictionary<string, double>>().WithSuccess().WithData(productSalesStatistics);
        }

    }
}