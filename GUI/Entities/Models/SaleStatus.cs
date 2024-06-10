using System;
using Entities.Interfaces;

namespace Entities.Models;

public class SaleStatus : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateAt { get; set; }

    public SaleStatus()
    {
    }

    public SaleStatus(string name)
    {
        this.Name = name;
    }

    public SaleStatus(long id, string name, DateTime createAt)
    {
        Id = id;
        this.Name = name;
        CreateAt = createAt;
    }
}