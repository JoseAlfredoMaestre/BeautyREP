using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Shared.Interfaces;
using DAL;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Implements;

public class UpdateService<T> : IUpdateService<T> where T : IUpdateEntity
{

    private static UpdateService<T>? _instance;

    public static UpdateService<T> GetInstance()
    {
        if (_instance == null) _instance = new UpdateService<T>();
        return _instance;
    }
    private UpdateService()
    {

    }

    private IUpdateRepository<T> Repository { get; set; }

    public UpdateService<T> withRepository(IUpdateRepository<T> repository)
    {
        Repository = repository;
        return this;
    }

    public Response<bool> Update(T entity)
    {
        try
        {
            return Repository.Update(entity);
        }
        catch (Exception e)
        {
            return ResponseBuilder<bool>.Error(e);
        }
    }
}