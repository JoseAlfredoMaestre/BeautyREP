using System;
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
        _productToUpdate.Stock = int.Parse(stockInput.Text);
        _productToUpdate.Name = nameInput.Text;
        _productToUpdate.Description = descripcionTextBox.Text;
        _productToUpdate.UnitPrice = double.Parse(unitaryCostInput.Text);
        _productToUpdate.Discount = int.Parse(discountInput.Text);
        _productToUpdate.Image = _imageBytes;

        Console.WriteLine(_productToUpdate.ToString());

        ProductService.GetInstance().Update(_productToUpdate);
        ProductUpdated?.Invoke();
        MessageBox.Show("Producto actualizada correctamente.");
        this.Dispose();
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