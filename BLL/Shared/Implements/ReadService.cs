using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Shared.Interfaces;
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


    private HashSet<T> Repository { get; set; }

    public ReadService<T> withRepository(HashSet<T> repository)
    {
        Repository = repository;
        return this;
    }

    public Response<HashSet<T>> GetAll()
    {
        try
        {
            return new ResponseBuilder<HashSet<T>>().WithData(Repository);
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
            var item = Repository.FirstOrDefault(item => item.Id == id);
            return new ResponseBuilder<T>().WithData(item);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return ResponseBuilder<T>.Error(e);
        }
    }
}