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

public partial class DeleteProduct : MaterialForm
{

    private Product _productToDelete;
    public event Action ProductDeleted;
    public DeleteProduct(Product product)
    {
        InitializeComponent();
        ThemeManager.ConfigureTheme(this);
        this._productToDelete = product;

        descriptionMultiLine.Enabled = false;
        materialLabel4.Text = _productToDelete.Stock.ToString();
        materialLabel7.Text = _productToDelete.Name;
        descriptionMultiLine.Text = _productToDelete.Description;
        if (_productToDelete.Image != null)
        {
            using var ms = new MemoryStream(_productToDelete.Image);
            pictureBox1.Image = Image.FromStream(ms);
        }
        else
        {
            pictureBox1.Image = null;
        }
        materialLabel6.Text = _productToDelete.UnitPrice.ToString("N0");
    }


    private void crtCityYesBtn_Click(object sender, EventArgs e)
    {
        ProductService.GetInstance().Delete(_productToDelete.Id);
        ProductDeleted?.Invoke();
        MessageBox.Show("Producto eliminado correctamente.");
        this.Dispose();
    }

    private void crtCityNoBtn_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}