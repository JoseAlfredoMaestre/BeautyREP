using System.Collections.Generic;
using BLL.Shared.Implements;
using BLL.Shared.Interfaces;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class SaleDetailsService : IReadService<SaleDetail>, IDeleteService<SaleDetail>, ICreateService<SaleDetail>
{
    private static SaleDetailsService? _instance;
    public static SaleDetailsService GetInstance() { return _instance ??= new SaleDetailsService(new HashSet<SaleDetail>()); }
    private SaleDetailsService(HashSet<SaleDetail> repository)
    {
        _repository = repository;
    }

    private HashSet<SaleDetail> _repository;


    public Response<SaleDetail> Save(params SaleDetail[] entity)
    {
        var service = CreateService<SaleDetail>.GetInstance().withRepository(_repository);
        return service.Save(entity);
    }

    public Response<HashSet<SaleDetail>> GetAll()
    {
        var service = ReadService<SaleDetail>.GetInstance().withRepository(_repository);
        return service.GetAll();
    }

    public Response<SaleDetail> GetById(long id)
    {
        var service = ReadService<SaleDetail>.GetInstance().withRepository(_repository);
        return service.GetById(id);
    }

    public Response<SaleDetail> Delete(long id)
    {
        var service = DeleteService<SaleDetail>.GetInstance().withRepository(_repository);
        return service.Delete(id);
    }
}