using System;
using System.Runtime.Serialization;

namespace Entities.Interfaces;

public interface IEntity
{
    long Id { get; set; }
    DateTime CreateAt { get; set; }
}