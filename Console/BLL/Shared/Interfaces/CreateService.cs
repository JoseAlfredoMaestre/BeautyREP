using System;
using System.Collections.Generic;
using Entities.Interfaces;
using Entities.Shared;

namespace BLL.Shared.Interfaces
{
    public interface ICreateService<T> : IService where T : ICreateEntity
    {
        Response<T> Save(params T[] entity);
    }
}