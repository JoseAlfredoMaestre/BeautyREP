using System;
using System.ComponentModel.DataAnnotations;
using Entities.Interfaces;

namespace Entities.Models;

public class Product : ICrudEntity
{
    [Required(ErrorMessage = "El stock es requerido")]
    [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
    public int Stock = 0;

    public long Id { get; set; }

    [Required(ErrorMessage = "El nombre es requerido")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
    public string Name { get; set; }

    [Required(ErrorMessage = "La descripción es requerida")]
    [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "El precio unitario es requerido")]
    [Range(0, double.MaxValue, ErrorMessage = "El precio unitario no puede ser negativo")]
    public double UnitPrice { get; set; }

    [Required(ErrorMessage = "El descuento es requerido")]
    [Range(0, 100, ErrorMessage = "El descuento debe estar entre 0 y 100")]
    public int Discount { get; set; } = 0;

    public DateTime CreateAt { get; set; }

    [Required(ErrorMessage = "La imagen es requerida")]
    public byte[]? Image { get; set; }

    public double TotalPrice => UnitPrice - UnitPrice * (double.Parse(Discount.ToString())/100);


    public Product()
    {
        CreateAt = DateTime.Now;
    }

    public Product(long id, string name, string? description, double unitPrice,int stock, int discount, byte[]? image = null)
    {
        Stock = stock;
        Id = id;
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        Discount = discount;
        CreateAt = DateTime.Now;
        Image = image;
    }

    public Product(long id, string name, string? description, double unitPrice,int stock, int discount, DateTime createAt, byte[]? image = null)
    {
        Stock = stock;
        Id = id;
        Name = name;
        Description = description;
        UnitPrice = unitPrice;
        Discount = discount;
        CreateAt = createAt;
        Image = image;
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
