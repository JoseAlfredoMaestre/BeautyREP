using System.Collections.Generic;
using BLL.Shared.Implements;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class SaleUbicationService
{
    private static SaleUbicationService? _instance;
    public static SaleUbicationService GetInstance() { return _instance ??= new SaleUbicationService(new HashSet<SaleUbication>()); }
    private SaleUbicationService(HashSet<SaleUbication> repository)
    {
        _repository = repository;
    }

    private HashSet<SaleUbication> _repository;

    public Response<SaleUbication> Save(params SaleUbication[] entity)
    {
        var service = CreateService<SaleUbication>.GetInstance().withRepository(_repository);
        return service.Save(entity);
    }

    public Response<HashSet<SaleUbication>> GetAll()
    {
        var service = ReadService<SaleUbication>.GetInstance().withRepository(_repository);
        return service.GetAll();
    }

    public Response<SaleUbication> GetById(long id)
    {
        var service = ReadService<SaleUbication>.GetInstance().withRepository(_repository);
        return service.GetById(id);
    }
}