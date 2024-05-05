using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Shared.Interfaces;
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
    private HashSet<T> Repository { get; set; }

    public DeleteService<T> withRepository(HashSet<T> repository)
    {
        Repository = repository;
        return this;
    }

    public Response<T> Delete(long id)
    {
        try
        {
            var item = Repository.FirstOrDefault(item => item.Id == id);
            if (item == null) return ResponseBuilder<T>.Fail("No se ha encontrado el id del item a eliminar");
            var success = Repository.Remove(item);
            return new ResponseBuilder<T>().WithSuccess(success).WithData(item);
        }
        catch (Exception e)
        {
            return ResponseBuilder<T>.Error(e);
        }
    }
}