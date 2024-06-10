using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Sales;

public partial class CreateSale : MaterialForm
{
    public event Action SaleCreated;

    public CreateSale()
{
    ThemeManager.ConfigureTheme(this);
    InitializeComponent();
    this.StartPosition = FormStartPosition.CenterScreen;

    var response = UserService.GetInstance().GetAll();
    if (response.IsSuccess)
    {
        var users = response.Data;
        customerCombo.Items.Clear();

        // Agregar las entidades completas de los usuarios al ComboBox
        customerCombo.Items.AddRange(users.ToArray());

        // Establecer la propiedad DisplayMember para mostrar los nombres de los usuarios
        customerCombo.DisplayMember = "Names";
    }

    var cities = CityService.GetInstance().GetAll().Data;
    cityCombo.Items.Clear();

    // Agregar las entidades completas de las ciudades al ComboBox
    cityCombo.Items.AddRange(cities.ToArray());

    // Establecer la propiedad DisplayMember para mostrar los nombres de las ciudades
    cityCombo.DisplayMember = "Name";
}

    private void generateSaleBtn_Click(object sender, EventArgs e)
{
    // Obtener el usuario y la ciudad seleccionados
    var selectedUser = (User)customerCombo.SelectedItem;
    var selectedCity = (City)cityCombo.SelectedItem;
    var dirección = addressMultilineInput.Text;
    SaleLocation location = new SaleLocation
    {
        City = selectedCity,
        Address = dirección,
    };

    var saleDetails = Home.GetInstance().SaleDetails;

    var sale = new Sale
    {
        SaleDetails = saleDetails,
        Location = location,
        User = selectedUser,
    };

    // Validar el objeto de venta
    var context = new ValidationContext(sale);
    var results = new List<ValidationResult>();
    if (!Validator.TryValidateObject(sale, context, results, true))
    {
        // Si la validación falla, mostrar el primer mensaje de error
        MessageBox.Show(results[0].ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    var response = SaleService.GetInstance().Save(sale);

    if (response.IsSuccess)
    {
        MessageBox.Show("Venta generada correctamente", "Venta generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Home.GetInstance().SaleDetails.Clear();
        this.Dispose();
        SaleCreated?.Invoke();
    }
    else
    {
        MessageBox.Show($"Error al generar la venta: {response.Msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
}