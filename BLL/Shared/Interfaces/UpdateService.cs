using System;
using System.Runtime.Serialization;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Interfaces
{
    public interface IUpdateService<in T> : IService where T : IUpdateEntity
    {

        Response<bool> Update(T entity);
    }
}