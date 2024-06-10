using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Shared.Interfaces;
using DAL;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Implements;

public class DeleteService<T> : IDeleteService<T> where T : IDeleteEntity
{
    private static DeleteService<T>? _instance;

    public static DeleteService<T> GetInstance()
    {
        if (_instance == null) _instance = new DeleteService<T>();
        return _instance;
    }
    private DeleteService()
    {

    }
    private IDeleteRepository<T> Repository { get; set; }

    public DeleteService<T> withRepository(IDeleteRepository<T> repository)
    {
        Repository = repository;
        return this;
    }

    public Response<T> Delete(params long[] ids)
    {
        try
        {
            foreach (var id in ids)
            {
                Repository.Delete(id);
            }
            return new ResponseBuilder<T>().WithSuccess(true);
        }
        catch (Exception e)
        {
            return ResponseBuilder<T>.Error(e);
        }
    }
}