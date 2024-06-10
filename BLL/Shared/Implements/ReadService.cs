using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Shared.Interfaces;
using DAL;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Implements;

public class ReadService<T> : IReadService<T> where T : IReadEntity
{

    private static ReadService<T>? _instance;

    public static ReadService<T> GetInstance()
    {
        if (_instance == null) _instance = new ReadService<T>();
        return _instance;
    }
    private ReadService()
    {

    }


    private IReadRepository<T> Repository { get; set; }

    public ReadService<T> withRepository(IReadRepository<T> repository)
    {
        Repository = repository;
        return this;
    }

    public Response<HashSet<T>> GetAll()
    {
        try
        {
            return Repository.GetAll();
        }
        catch (Exception e)
        {
            return ResponseBuilder<HashSet<T>>.Error(e);
        }
    }

    public Response<T> GetById(long id)
    {
        try
        {
            return Repository.GetById(id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return ResponseBuilder<T>.Error(e);
        }
    }
}