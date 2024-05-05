using System;
using System.Collections.Generic;
using Entities.Interfaces;

namespace DAL.Repositories
{
    public abstract class GeneralRepository<T> where T : IEntity
    {
        public HashSet<T> repository { get; } = new HashSet<T>();
    }
}