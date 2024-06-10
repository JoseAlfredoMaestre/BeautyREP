using System;
using Entities.Interfaces;

namespace Entities.Models;

public class SaleDetail : IReadEntity, ICreateEntity, IDeleteEntity
{
    public long Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public double Subtotal => Product.TotalPrice * Quantity;

    public Sale Sale { get; set; }
    public DateTime CreateAt { get; set; }


    public SaleDetail()
    {
        Product = new Product();
        Sale = new Sale();
        CreateAt = DateTime.Now;
    }

    public SaleDetail(long id, Product product, int quantity, DateTime createAt, long saleId)
    {
        Id = id;
        Product = product;
        Quantity = quantity;
        CreateAt = createAt;
        Sale = new Sale();
        Sale.Id = saleId;
    }

    public SaleDetail(Product product, int saleId, int quantity)
    {
        Product = product;
        Quantity = quantity;
        CreateAt = DateTime.Now;
        Sale sale = new Sale();
        sale.Id = saleId;
    }
    public SaleDetail(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
        CreateAt = DateTime.Now;
    }

}