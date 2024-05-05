using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Shared.Interfaces;
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


    private HashSet<T> Repository { get; set; }

    public UpdateService<T> withRepository(HashSet<T> repository)
    {
        Repository = repository;
        return this;
    }

    public Response<T> Update(T entity, long id)
    {
        try
        {
            T old = default;
            foreach (var item in Repository.Where(item => item.Id == id))
            {
                old = item;
                Repository.Remove(item);
            }

            Repository.Add(entity);
            return new ResponseBuilder<T>().WithData(old).WithSuccess(true);
        }
        catch (Exception e)
        {
            return ResponseBuilder<T>.Error(e);
        }
    }
}