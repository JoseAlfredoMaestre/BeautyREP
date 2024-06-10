using System;
using System.Runtime.Serialization;

namespace Entities.Interfaces;

public interface ICrudEntity : ICreateEntity, IReadEntity, IUpdateEntity, IDeleteEntity
{
    
}