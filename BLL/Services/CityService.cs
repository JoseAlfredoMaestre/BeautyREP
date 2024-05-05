using System.Collections.Generic;
using BLL.Shared.Implements;
using BLL.Shared.Interfaces;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class CityService : ICrudService<City>
{
    private static CityService? _instance;
    public static CityService GetInstance() { return _instance ??= new CityService(new HashSet<City>()); }
    private CityService(HashSet<City> repository)
    {
        _repository = repository;
    }

    private HashSet<City> _repository;



    public Response<City> Save(params City[] entity)
    {
        var service = CreateService<City>.GetInstance().withRepository(_repository);
        return service.Save(entity);
    }

    public Response<HashSet<City>> GetAll()
    {
        var service = ReadService<City>.GetInstance().withRepository(_repository);
        return service.GetAll();
    }

    public Response<City> GetById(long id)
    {
        var service = ReadService<City>.GetInstance().withRepository(_repository);
        return service.GetById(id);
    }

    public Response<City> Update(City entity, long id)
    {
        var service = UpdateService<City>.GetInstance().withRepository(_repository);
        return service.Update(entity, id);
    }

    public Response<City> Delete(long id)
    {
        var service = DeleteService<City>.GetInstance().withRepository(_repository);
        return service.Delete(id);
    }
}