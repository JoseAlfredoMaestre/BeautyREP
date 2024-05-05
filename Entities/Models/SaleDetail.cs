using System;
using Entities.Interfaces;

namespace Entities.Models;

public class SaleDetail : IReadEntity, ICreateEntity, IDeleteEntity
{
    public long Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public double Subtotal => Product.TotalPrice * Quantity;
    public DateTime CreateAt { get; set; }


    public SaleDetail()
    {
        Product = new Product();
        CreateAt = DateTime.Now;
    }

    public SaleDetail(long id, Product product, int quantity, DateTime createAt)
    {
        Id = id;
        Product = product;
        Quantity = quantity;
        CreateAt = createAt;
    }

    public SaleDetail(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
        CreateAt = DateTime.Now;
    }
}