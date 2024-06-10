using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Sales;

public partial class DeleteSale : MaterialForm
{

    private Sale _saleToDelete;
    public event Action SaleDeleted;
    public DeleteSale(Sale sale)
    {
        InitializeComponent();
        ThemeManager.ConfigureTheme(this);
        this._saleToDelete = sale;
        this.StartPosition = FormStartPosition.CenterScreen;

        saleIdLbl.Text = sale.Id.ToString();
    }


    private void deleteSaleYesBtn_Click(object sender, EventArgs e)
    {
        ProductService.GetInstance().Delete(_saleToDelete.Id);
        SaleDeleted?.Invoke();
        MessageBox.Show("Venta eliminada correctamente.");
        this.Dispose();
    }

    private void deleteSaleNoBtn_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

}