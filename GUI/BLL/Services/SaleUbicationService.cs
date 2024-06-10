using System.Collections.Generic;
using BLL.Shared.Implements;
using DAL.Repositories;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class SaleUbicationService
{
    private static SaleUbicationService? _instance;
    public static SaleUbicationService GetInstance() { return _instance ??= new SaleUbicationService(new SaleLocationRepository()); }
    private SaleUbicationService(SaleLocationRepository repository)
    {
        _repository = repository;
    }

    private SaleLocationRepository _repository;

    public Response<SaleLocation> Save(params SaleLocation[] entity)
    {
        var service = CreateService<SaleLocation>.GetInstance().withRepository(_repository);
        return service.Save(entity);
    }

    public Response<HashSet<SaleLocation>> GetAll()
    {
        var service = ReadService<SaleLocation>.GetInstance().withRepository(_repository);
        return service.GetAll();
    }

    public Response<SaleLocation> GetById(long id)
    {
        var service = ReadService<SaleLocation>.GetInstance().withRepository(_repository);
        return service.GetById(id);
    }
}