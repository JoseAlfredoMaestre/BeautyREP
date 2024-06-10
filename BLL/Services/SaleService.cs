using System;
using System.Collections.Generic;
using BLL.Shared.Implements;
using DAL.Repositories;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class SaleService
{
    private static SaleService? _instance;
    public static SaleService GetInstance() { return _instance ??= new SaleService(new SaleRepository()); }
    private SaleService(SaleRepository repository)
    {
        _repository = repository;
    }

    private SaleRepository _repository;


    public Response<Sale> Save(params Sale[] entity)
    {
        var service = CreateService<Sale>.GetInstance().withRepository(_repository);
        var res = service.Save(entity);
        if (res.IsSuccess)
        {
            try
            {
                foreach (var sale in entity)
                {
                    foreach (var saleDetail in sale.SaleDetails)
                    {
                        ProductService.GetInstance().Update(saleDetail.Product.DeductStock(saleDetail.Quantity));
                    }
                }
            }
            catch (Exception e)
            {
                return ResponseBuilder<Sale>.Error(e);
            }
        }
        return res;
    }

    public Response<HashSet<Sale>> GetAll()
    {
        var service = ReadService<Sale>.GetInstance().withRepository(_repository);
        return service.GetAll();
    }

    public Response<Sale> GetById(long id)
    {
        var service = ReadService<Sale>.GetInstance().withRepository(_repository);
        return service.GetById(id);
    }

    public Response<Sale> Delete(params long[] ids)
    {
        var service = DeleteService<Sale>.GetInstance().withRepository(_repository);
        return service.Delete(ids);
    }
}