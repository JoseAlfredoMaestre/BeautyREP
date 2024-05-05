using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Interfaces
{
    public interface IReadService<T> : IService where T : IReadEntity
    {
        Response<HashSet<T>> GetAll();
        Response<T> GetById(long id);
    }
}