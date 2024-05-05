using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Interfaces;

namespace Entities.Models;

public class Sale : IReadEntity, ICreateEntity, IDeleteEntity
{

    public long Id { get; set; }
    public double BasePrice => SaleDetails.Sum(item => item.Subtotal);
    public double TotalPrice => BasePrice - BasePrice * Discount;
    public int Discount { get; set; }
    public DateTime CreateAt { get; set; }

    public HashSet<SaleDetail> SaleDetails { get; set; }
    public SaleUbication Ubication { get; set; }


    public Sale()
    {
        Discount = 0;
        SaleDetails = new();
        CreateAt = DateTime.Now;
        Ubication = new();
    }

    public Sale(int discount)
    {
        Discount = discount;
        SaleDetails = new();
        CreateAt = DateTime.Now;
        Ubication = new();
    }

    public Sale(int discount, HashSet<SaleDetail> saleDetails)
    {
        Discount = discount;
        SaleDetails = saleDetails;
        CreateAt = DateTime.Now;
        Ubication = new();
    }

    public Sale(long id, int discount, DateTime createAt, HashSet<SaleDetail> saleDetails, SaleUbication ubication)
    {
        Id = id;
        Discount = discount;
        CreateAt = createAt;
        SaleDetails = saleDetails;
        Ubication = ubication;
    }
}