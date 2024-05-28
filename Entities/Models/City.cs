using System;
using Entities.Interfaces;

namespace Entities.Models;

public class City : ICrudEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreateAt { get; set; }

    public City()
    {
        CreateAt = DateTime.Now;
    }

    public City(long id, string name, string? description, DateTime createAt)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        CreateAt = createAt;
    }

    public City(string name, string? description)
    {
        this.Name = name;
        this.Description = description;
        CreateAt = DateTime.Now;

    }
}