using System.Collections.Generic;
using BLL.Shared.Implements;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class SaleService
{
    private static SaleService? _instance;
    public static SaleService GetInstance() { return _instance ??= new SaleService(new HashSet<Sale>()); }
    private SaleService(HashSet<Sale> repository)
    {
        _repository = repository;
    }

    private HashSet<Sale> _repository;


    public Response<Sale> Save(params Sale[] entity)
    {
        var service = CreateService<Sale>.GetInstance().withRepository(_repository);
        return service.Save(entity);
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

    public Response<Sale> Delete(long id)
    {
        var service = DeleteService<Sale>.GetInstance().withRepository(_repository);
        return service.Delete(id);
    }
}