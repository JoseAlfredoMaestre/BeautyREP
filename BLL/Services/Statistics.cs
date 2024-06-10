using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Repositories;
using Entities.Shared;

namespace BLL.Services;

public class Statistics
{
    private readonly StatsRepository _stats = new();

    // (El dictionary es un map)

    // Obtiene el valor de las ventas de todos los meses en un año en especifico, por default el año es el actual. Dictionary<Nombre del mes (string), valor de las ventas (double)>
    public Response<Dictionary<string, double>> GetMonthlySales(int? year = null)
    {
        try
        {
            return _stats.GetMonthlySales(year);
        }
        catch (SqlException ex)
        {
            return ResponseBuilder<Dictionary<string, double>>.Error(ex);
        }
    }

    // Obtiene el valor de las ventas de todos los años, <Año (int), valor de las ventas (double)>
    public Response<Dictionary<int, double>> GetAnnualSales()
    {
        try
        {
            return _stats.GetAnnualSales();
        }
        catch (SqlException ex)
        {
            return ResponseBuilder<Dictionary<int, double>>.Error(ex);
        }
    }

    // Obtiene la cantidad de ventas de todos los meses en un año en especifico, por default el año es el actual. Dictionary<Nombre del mes (string), cantidad de ventas (int)>
    public Response<Dictionary<string, int>> GetMonthlySalesCount(int? year = null)
    {
        try
        {
            return _stats.GetMonthlySalesCount(year);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, int>>.Error(ex);
        }
    }

    // Obtiene la cantidad de ventas de todos los años. Dictionary<Año (int), cantidad de ventas (int)>
    public Response<Dictionary<int, int>> GetAnnualSalesCount()
    {
        try
        {
            return _stats.GetAnnualSalesCount();
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<int, int>>.Error(ex);
        }
    }

    // Obtiene la cantidad de usuarios registrados de todos los meses en un año en especifico, por default el año es el actual. Dictionary<Nombre del mes (string), cantidad de usuarios (int)>
    public Response<Dictionary<string, int>> GetMonthlyUserCreated(int? year = null)
    {
        try
        {
            return _stats.GetMonthlyUserCreated(year);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, int>>.Error(ex);
        }
    }

    // Obtiene la cantidad de usuarios registrados de todos los años. Dictionary<Año (int), cantidad de usuarios (int)>
    public Response<Dictionary<int, int>> GetAnnualUserCreated()
    {
        try
        {
            return _stats.GetAnnualUserCreated();
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<int, int>>.Error(ex);
        }
    }

    // Obtiene la cantidad de ventas por cada producto en un dia en especifico, por default el dia es el actual. Dictionary<Nombre del producto (string), valor de las ventas (int)>
    public Response<Dictionary<string, int>> GetDailyProductSales(DateTime? day = null)
    {
        try
        {
            return _stats.GetDailyProductSales(day);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, int>>.Error(ex);
        }
    }

    // Obtiene la cantidad de ventas por cada producto en un mes en especifico, por default el mes es el actual y se peude especificar de que año es ese mes, por default el año es el actual.
    // Dictionary<Nombre del producto (string), valor de las ventas (int)>
    public Response<Dictionary<string, int>> GetMonthlyProductSales(int? month = null, int? year = null)
    {
        try
        {
            return _stats.GetMonthlyProductSales(month, year);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, int>>.Error(ex);
        }
    }

    // Obtiene la cantidad de ventas por cada producto en un año en especifico, por default el año es el actual. Dictionary<Nombre del producto (string), valor de las ventas (int)>
    public Response<Dictionary<string, int>> GetAnnualProductSales(int? year = null)
    {
        try
        {
            return _stats.GetAnnualProductSales(year);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, int>>.Error(ex);
        }
    }

    // Obtiene el valor de las ventas por cada producto en un dia en especifico, por default el año es el actual. Dictionary<Nombre del producto (string), valor de las ventas (double)>
    public Response<Dictionary<string, double>> GetDailyProductSalesValue(DateTime? day = null)
    {
        try
        {
            return _stats.GetDailyProductSalesValue(day);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, double>>.Error(ex);
        }
    }

    // Obtiene el valor de las ventas por cada producto en un mes en especifico, por default el mes es el actual y se peude especificar de que año es ese mes, por default el año es el actual.
    // Dictionary<Nombre del producto (string), valor de las ventas (double)>
    public Response<Dictionary<string, double>> GetMonthlyProductSalesValue(int? year = null, int? month = null)
    {
        try
        {
            return _stats.GetMonthlyProductSalesValue(month, year);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, double>>.Error(ex);
        }
    }

    // Obtiene el valor de las ventas por cada producto en un año en especifico, por default el año es el actual. Dictionary<Nombre del producto (string), valor de las ventas (double)>
    public Response<Dictionary<string, double>> GetAnnualProductSalesValue(int? year = null)
    {
        try
        {
            return _stats.GetAnnualProductSalesValue(year);
        }
        catch (SqlException ex)
        {
            // Handle exception
            return ResponseBuilder<Dictionary<string, double>>.Error(ex);
        }
    }
}