using System;
using Entities.Interfaces;

namespace Entities.Models;

public class SaleUbication : IReadEntity, ICreateEntity
{
    public long Id { get; set; }
    public string Adress { get; set; }
    public City City { get; set; }
    public DateTime CreateAt { get; set; }


    public SaleUbication()
    {
        City = new();
        CreateAt = DateTime.Now;
    }

    public SaleUbication(long id, string adress, City city, DateTime createAt)
    {
        Id = id;
        Adress = adress;
        City = city;
        CreateAt = createAt;
    }

    public SaleUbication(string adress, City city)
    {
        Adress = adress;
        City = city;
        CreateAt = DateTime.Now;
    }
}