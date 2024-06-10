using System;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Cities;

public partial class DeleteCity : MaterialForm
{

    private City _cityToDelete;
    public event Action CityDeleted;
    public DeleteCity(City city)
    {
        ThemeManager.ConfigureTheme(this);
        InitializeComponent();
        this._cityToDelete = city;
        this.StartPosition = FormStartPosition.CenterScreen;


        descriptionMultiLine.Enabled = false;

        materialLabel7.Text = _cityToDelete.Name;
        descriptionMultiLine.Text = _cityToDelete.Description;
    }


    private void crtCityYesBtn_Click(object sender, EventArgs e)
    {
        CityService.GetInstance().Delete(_cityToDelete.Id);
        CityDeleted?.Invoke();
        MessageBox.Show("Ciudad eliminada correctamente.");
        this.Dispose();
    }

    private void crtCityNoBtn_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
}