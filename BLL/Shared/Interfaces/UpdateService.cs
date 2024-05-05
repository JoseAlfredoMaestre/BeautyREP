using System;
using System.Runtime.Serialization;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Interfaces
{
    public interface IUpdateService<T> : IService where T : IUpdateEntity
    {

        Response<T> Update(T entity, long id);
    }
}