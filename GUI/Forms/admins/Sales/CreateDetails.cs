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
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Sales;

public partial class CreateDetails : MaterialForm
{
    public event Action SaleDetailsCreated;
    private byte[] _imageBytes;
    public SaleDetail SaleDetail;

    public CreateDetails()
    {
        ThemeManager.ConfigureTheme(this);
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;


        var products = ProductService.GetInstance().GetAll().Data;
        productCombo.Items.Clear();

        foreach (var product in products)
        {
            productCombo.Items.Add(product.Name);
        }

    }

    private void generateSaleBtn_Click(object sender, EventArgs e)
    {
        if (productCombo.SelectedItem == null)
        {
            MessageBox.Show("Debe seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(quantityInput.Text, out int quantity))
        {
            MessageBox.Show("La cantidad debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var product = ProductService.GetInstance().GetAll().Data.FirstOrDefault(p => p.Name == productCombo.SelectedItem.ToString());

        if (product != null)
        {
            if(quantity > product.Stock)
            {
                MessageBox.Show("La cantidad ingresada supera el stock del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaleDetail saleDetail = new SaleDetail(product, quantity);
            if (saleDetail != null)
            {
                ValidationContext context = new(saleDetail, null, null);

                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(saleDetail, context, errors, true))
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
                    Home.GetInstance().SaleDetails.Add(saleDetail);
                    MessageBox.Show("Detalle de venta creado correctamente.");
                    this.Dispose();
                    SaleDetailsCreated?.Invoke();
                }
            }
        }


    }

    private void productCombo_SelectedIndexChanged(object sender, EventArgs e)
    {

        // Verificar si hay un elemento seleccionado en el ComboBox
        if (productCombo.SelectedItem != null)
        {
            // Si hay un elemento seleccionado, habilitar el TextBox
            quantityInput.Enabled = true;


            // Obtener el producto seleccionado
            var selectedProduct = ProductService.GetInstance().GetAll().Data.FirstOrDefault(p => p.Name == productCombo.SelectedItem.ToString());

            // Verificar si el producto tiene una imagen
            if (selectedProduct != null && selectedProduct.Image != null)
            {
                quantityLbl.Text = selectedProduct.Stock.ToString();
                // Convertir el array de bytes a una imagen y mostrarla en el PictureBox
                using (var ms = new MemoryStream(selectedProduct.Image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Si el producto no tiene una imagen, limpiar el PictureBox
                pictureBox1.Image = null;
            }
        }
        else
        {
            // Si no hay un elemento seleccionado, deshabilitar el TextBox y limpiar el PictureBox
            quantityInput.Enabled = false;
            pictureBox1.Image = null;
        }
    }

    private void quantityInput_TextChanged(object sender, EventArgs e)
{
    // Verificar si hay un elemento seleccionado en el ComboBox
    if (productCombo.SelectedItem != null)
    {
        // Obtener el producto seleccionado
        var selectedProduct = ProductService.GetInstance().GetAll().Data.FirstOrDefault(p => p.Name == productCombo.SelectedItem.ToString());

        // Verificar si se ingresó una cantidad válida
        if (int.TryParse(quantityInput.Text, out int quantity))
        {
            // Calcular el subtotal y mostrarlo en el TextBox
            double subtotal = selectedProduct.TotalPrice * quantity;
            subtotalLbl.Text = subtotal.ToString("N2");
        }
        else
        {
            // Si no se ingresó una cantidad válida, limpiar el TextBox
            subtotalLbl.Text = string.Empty;
        }
    }
    else
    {
        // Si no hay un elemento seleccionado, limpiar el TextBox
        subtotalLbl.Text = string.Empty;
    }
}
}