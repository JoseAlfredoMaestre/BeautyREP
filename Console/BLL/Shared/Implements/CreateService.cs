using System;
using System.Collections.Generic;
using BLL.Shared.Interfaces;
using DAL;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Implements;

public class CreateService<T> : ICreateService<T> where T : ICreateEntity
{

    private static CreateService<T>? _instance;

    public static CreateService<T> GetInstance()
    {
        if (_instance == null) _instance = new CreateService<T>();
        return _instance;
    }
    private CreateService() { }

    private ICreateRepository<T> Repository { get; set; }
    public CreateService<T> withRepository(ICreateRepository<T> repository)
    {
        Repository = repository;
        return this;
    }

    public Response<T> Save(params T[] entities)
    {
        try
        {
            foreach (var entity in entities)
            {
                Repository.Insert(entity);
            }
            return new ResponseBuilder<T>().WithSuccess(true);
        }
        catch (Exception e)
        {
            return ResponseBuilder<T>.Error(e);
        }
    }

}