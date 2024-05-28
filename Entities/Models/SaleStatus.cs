using System;
using Entities.Interfaces;

namespace Entities.Models;

public class SaleStatus : IEntity
{
    public long Id { get; set; }
    public string name { get; set; }
    public DateTime CreateAt { get; set; }

    public SaleStatus()
    {
    }

    public SaleStatus(string name)
    {
        this.name = name;
    }

    public SaleStatus(long id, string name, DateTime createAt)
    {
        Id = id;
        this.name = name;
        CreateAt = createAt;
    }
}