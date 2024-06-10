using System.Collections.Generic;
using BLL.Shared.Implements;
using BLL.Shared.Interfaces;
using DAL;
using DAL.Repositories;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class CityService : ICrudService<City>
{
    private static CityService? _instance;

    public static CityService GetInstance()
    {
        return _instance ??= new CityService(new CityRepository());
    }
    private CityService(CityRepository repository)
    {
        _repository = repository;
    }

    private readonly CityRepository _repository;

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

    public Response<bool> Update(City entity)
    {
        var service = UpdateService<City>.GetInstance().withRepository(_repository);
        return service.Update(entity);
    }

    public Response<City> Delete(params long[] ids)
    {
        var service = DeleteService<City>.GetInstance().withRepository(_repository);
        return service.Delete(ids);
    }
}