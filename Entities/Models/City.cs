using System;
using Entities.Interfaces;

namespace Entities.Models;

public class City : ICrudEntity
{
    public long Id { get; set; }
    public string Nombre { get; set; }
    public string? Desc { get; set; }
    public DateTime CreateAt { get; set; }

    public City()
    {
        CreateAt = DateTime.Now;
    }

    public City(long id, string nombre, string? desc, DateTime createAt)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Desc = desc;
        CreateAt = createAt;
    }

    public City(string nombre, string? desc)
    {
        this.Nombre = nombre;
        this.Desc = desc;
        CreateAt = DateTime.Now;

    }
}