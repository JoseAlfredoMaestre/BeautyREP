using System;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Cities;

public partial class UpdateCity : MaterialForm
{
    private City _cityToUpdate;
    public event Action CityUpdated;

    public UpdateCity(City city)
    {
        this.StartPosition = FormStartPosition.CenterScreen;
        ThemeManager.ConfigureTheme(this);
        this._cityToUpdate = city;
        InitializeComponent();

        nameInput.Text = city.Name;
        descripcionTextBox.Text = city.Description;
    }

    private void actualizarCiudadBtn_Click(object sender, EventArgs e)
    {
        _cityToUpdate.Name = nameInput.Text;
        _cityToUpdate.Description = descripcionTextBox.Text;

        Console.WriteLine(_cityToUpdate.ToString());

        CityService.GetInstance().Update(_cityToUpdate);
        CityUpdated?.Invoke();
        MessageBox.Show("Ciudad actualizada correctamente.");
        this.Dispose();
    }
}