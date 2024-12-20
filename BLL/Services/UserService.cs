﻿using System.Collections.Generic;
using BLL.Shared.Implements;
using BLL.Shared.Interfaces;
using DAL.Repositories;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class UserService : ICrudService<User>
{

    private static UserService? _instance;

    public static UserService GetInstance() { return _instance ??= new UserService(new UserRepository()); }
    private UserService(UserRepository repository)
    {
        _repository = repository;
    }

    private UserRepository _repository;

    public Response<User> Save(params User[] entity)
    {
        var service = CreateService<User>.GetInstance().withRepository(_repository);
        return service.Save(entity);
    }

    public Response<HashSet<User>> GetAll()
    {
        var service = ReadService<User>.GetInstance().withRepository(_repository);
        return service.GetAll();
    }

    public Response<User> GetById(long id)
    {
        var service = ReadService<User>.GetInstance().withRepository(_repository);
        return service.GetById(id);
    }

    public Response<bool> Update(User entity)
    {
        var service = UpdateService<User>.GetInstance().withRepository(_repository);
        return service.Update(entity);
    }

    public Response<User> Delete(params long[] ids)
    {
        var service = DeleteService<User>.GetInstance().withRepository(_repository);
        return service.Delete(ids);
    }
}