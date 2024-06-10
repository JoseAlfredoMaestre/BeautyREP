using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BLL.Services;
using Entities.Models;

namespace GUI.Forms.admins.Cities;

public partial class CreateCity : MaterialForm
{
    public event Action CityCreated;

    public CreateCity()
    {
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        InitializeComponent();
    }

    private void createCityBtn_Click(object sender, EventArgs e)
    {
        string name = nameInput.Text;
        string description = descripcionTextBox.Text;

        var lastCity = CityService.GetInstance().GetAll().Data.LastOrDefault();
        int newId = (int)((lastCity != null) ? lastCity.Id + 1 : 1);

        City city = new City
        {
            Name = name,
            Description = description,
        };

        if (city != null)
        {
            ValidationContext context = new(city, null, null);

            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(city, context, errors, true))
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
                CityService.GetInstance().Save(city);
                MessageBox.Show("Ciudad creada correctamente.");
                this.Dispose();
                CityCreated?.Invoke();
            }
        }
    }
}