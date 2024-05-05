using System;
using System.Runtime.Serialization;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Interfaces
{
    public interface IDeleteService<T> : IService where T : IDeleteEntity
    {
        Response<T> Delete(long id);
    }
}