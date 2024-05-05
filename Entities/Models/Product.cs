using System;
using Entities.Interfaces;

namespace Entities.Models;

public class Product : ICrudEntity
{
    public int Stock = 0;
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Desc { get; set; }
    public double UnitPrice { get; set; }
    public int Discount { get; set; } = 0;
    public double TotalPrice => UnitPrice - UnitPrice * Discount;
    public DateTime CreateAt { get; set; }

    public Product()
    {

    }

    public Product(long id, string name, string? desc, double unitPrice,int stock, int discount)
    {
        Stock = stock;
        Id = id;
        Name = name;
        Desc = desc;
        UnitPrice = unitPrice;
        Discount = discount;
        CreateAt = DateTime.Now;
    }

    public Product(long id, string name, string? desc, double unitPrice,int stock, int discount, DateTime createAt)
    {
        Stock = stock;
        Id = id;
        Name = name;
        Desc = desc;
        UnitPrice = unitPrice;
        Discount = discount;
        CreateAt = createAt;
    }
    public void AddStock(int count)
    {
        this.Stock += count;
    }
    public void DeductStock(int count)
    {
        AddStock(-count);
    }

    public void UpdateStock(int count)
    {
        Stock = count;
    }
}