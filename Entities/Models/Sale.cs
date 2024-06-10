using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public SaleStatus Status { get; set; }

    public HashSet<SaleDetail> SaleDetails { get; set; }
    [Required(ErrorMessage = "La ubicación es requerida.")]
    public SaleLocation Location { get; set; }
    [Required(ErrorMessage = "El usuario es requerido.")]
    public User User { get; set; } = new();

    public Sale()
    {
        Discount = 0;
        SaleDetails = new();
        CreateAt = DateTime.Now;
        Location = new();
    }

    public Sale(int discount)
    {
        Discount = discount;
        SaleDetails = new();
        CreateAt = DateTime.Now;
        Location = new();
    }

    public Sale(int discount, HashSet<SaleDetail> saleDetails)
    {
        Discount = discount;
        SaleDetails = saleDetails;
        CreateAt = DateTime.Now;
        Location = new();
    }

    public Sale(long id, int discount, DateTime createAt, SaleStatus status, HashSet<SaleDetail> saleDetails, SaleLocation location, User user)
    {
        Id = id;
        Discount = discount;
        CreateAt = createAt;
        Status = status;
        SaleDetails = saleDetails;
        Location = location;
        User = user;
    }

}