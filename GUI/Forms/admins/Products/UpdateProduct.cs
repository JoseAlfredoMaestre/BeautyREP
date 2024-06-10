using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Products;

public partial class UpdateProduct : MaterialForm
{
    private Product _productToUpdate;
    public event Action ProductUpdated;
    private byte[] _imageBytes;

    public UpdateProduct(Product product)
    {
        this._productToUpdate = product;
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        ThemeManager.ConfigureTheme(this);
        stockInput.Text = product.Stock.ToString();
        nameInput.Text = product.Name;
        descripcionTextBox.Text = product.Description;
        unitaryCostInput.Text = product.UnitPrice.ToString("N0");
        discountInput.Text = product.Discount.ToString();
        if (_productToUpdate.Image != null)
        {
            using var ms = new MemoryStream(_productToUpdate.Image);
            productPictureBox.Image = Image.FromStream(ms);
        }
        else
        {
            productPictureBox.Image = null;
        }
    }

    private void updateProductBtn_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(stockInput.Text, out int stock))
        {
            MessageBox.Show("El stock debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string name = nameInput.Text;
        string description = descripcionTextBox.Text;

        if (!double.TryParse(unitaryCostInput.Text, out double unitPrice))
        {
            MessageBox.Show("El precio unitario debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(discountInput.Text, out int discount))
        {
            MessageBox.Show("El descuento debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _productToUpdate.Stock = stock;
        _productToUpdate.Name = name;
        _productToUpdate.Description = description;
        _productToUpdate.UnitPrice = unitPrice;
        _productToUpdate.Discount = discount;
        _productToUpdate.Image = _imageBytes;

        ValidationContext context = new(_productToUpdate, null, null);
        IList<ValidationResult> errors = new List<ValidationResult>();

        if (!Validator.TryValidateObject(_productToUpdate, context, errors, true))
        {
            foreach (ValidationResult result in errors)
            {
                Console.WriteLine((result.ErrorMessage));
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        else
        {
            // Solo actualiza el producto si todas las validaciones pasaron correctamente
            ProductService.GetInstance().Update(_productToUpdate);
            MessageBox.Show("Producto actualizado correctamente.");
            this.Dispose();
            ProductUpdated?.Invoke();
        }
    }

    private void productImgBtn_Click(object sender, EventArgs e)
    {
        OpenFileDialog dialog = new();
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
        dialog.Title = "Seleccione una imagen";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            productPictureBox.Image = new Bitmap(dialog.FileName);
            _imageBytes = File.ReadAllBytes(dialog.FileName);
        }
    }
}