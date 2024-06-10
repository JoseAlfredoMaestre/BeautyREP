using System.Collections.Generic;
using BLL.Shared.Implements;
using BLL.Shared.Interfaces;
using DAL.Repositories;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class ProductService : ICrudService<Product>
{

    private static ProductService? _instance;

    public static ProductService GetInstance()
    {
        if (_instance == null) _instance = new ProductService(new ProductRepository());
        return _instance;
    }

    private ProductService(ProductRepository repository)
    {
        _repository = repository;
    }

    private ProductRepository _repository;

    public Response<Product> Save(params Product[] entity)
    {
        var service = CreateService<Product>.GetInstance().withRepository(_repository);
        return service.Save(entity);
    }

    public Response<HashSet<Product>> GetAll()
    {
        var service = ReadService<Product>.GetInstance().withRepository(_repository);
        return service.GetAll();
    }

    public Response<Product> GetById(long id)
    {
        var service = ReadService<Product>.GetInstance().withRepository(_repository);
        return service.GetById(id);
    }

    public Response<bool> Update(Product entity)
    {
        var service = UpdateService<Product>.GetInstance().withRepository(_repository);
        return service.Update(entity);
    }

    public Response<Product> Delete(params long[] ids)
    {
        var service = DeleteService<Product>.GetInstance().withRepository(_repository);
        return service.Delete(ids);
    }
}