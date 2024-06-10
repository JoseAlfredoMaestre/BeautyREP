using System;
using Entities.Interfaces;

namespace Entities.Models;

public class SaleLocation : IReadEntity, ICreateEntity
{
    public long Id { get; set; }
    public string Address { get; set; }
    public City City { get; set; }
    public DateTime CreateAt { get; set; }


    public SaleLocation()
    {
        City = new();
        CreateAt = DateTime.Now;
    }

    public SaleLocation(long id, string address, City city, DateTime createAt)
    {
        Id = id;
        Address = address;
        City = city;
        CreateAt = createAt;
    }

    public SaleLocation(string address, City city)
    {
        Address = address;
        City = city;
        CreateAt = DateTime.Now;
    }
}