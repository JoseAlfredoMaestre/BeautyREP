using System.Collections.Generic;
using Entities.Models;
using Entities.Shared;

namespace DAL
{
    public interface ICreateRepository<in T>
    {
        Response<bool> Insert(T entity);
    }

    public interface IReadRepository<T>
    {
        Response<T> GetById(long id);
        Response<HashSet<T>> GetAll();
    }

    public interface IUpdateRepository<in T>
    {
        Response<bool> Update(T entity);
    }

    public interface IDeleteRepository<T>
    {
        Response<bool> Delete(long id);
    }

    public interface IRepository<T> : ICreateRepository<T>, IReadRepository<T>, IUpdateRepository<T>, IDeleteRepository<T>
    {
    }

    public interface IAuthRepository
    {
        Response<Person> Authenticate(Person person);
    }

}