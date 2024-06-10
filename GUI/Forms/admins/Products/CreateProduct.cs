using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Products;

public partial class CreateProduct : MaterialForm
{
    public event Action ProductCreated;
    private byte[] _imageBytes;

    public CreateProduct()
    {
        ThemeManager.ConfigureTheme(this);
        InitializeComponent();
    }

    private void createProductBtn_Click(object sender, EventArgs e)
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

        var lastProduct = ProductService.GetInstance().GetAll().Data.LastOrDefault();
        int newId = (int)((lastProduct != null) ? lastProduct.Id + 1 : 1);

        Product product = new Product
        {
            Stock = stock,
            Name = name,
            Description = description,
            UnitPrice = unitPrice,
            Discount = discount,
            Image = _imageBytes,
        };

        if (product != null)
        {
            ValidationContext context = new(product, null, null);

            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(product, context, errors, true))
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
                // Solo guarda el usuario si todas las validaciones pasaron correctamente
                ProductService.GetInstance().Save(product);
                MessageBox.Show("Producto creado correctamente.");
                this.Dispose();
                ProductCreated?.Invoke();
            }
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