using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin.Controls;

namespace GUI.Forms.Users
{
    public partial class UserHome : MaterialForm
    {
        public HashSet<SaleDetail> SaleDetails;
        private static UserHome _instance;

        public static UserHome GetInstance()
        {
            return _instance ??= new UserHome();
        }

        public UserHome()
        {
            ThemeManager.ConfigureTheme(this);
            _instance = this;
            InitializeComponent();

            SaleDetails = new();

            LoadDataToProductsList();
            LoadDataToSalesList();
            LoadDataToSaleDetailsList();
        }

        //Cargar datos a la Lista de productos
        private void LoadDataToProductsList()
        {
            productosListView.Columns.Add("ID", 100);
            productosListView.Columns.Add("Stock", 100);
            productosListView.Columns.Add("Nombre", 200);
            productosListView.Columns.Add("Descripcion", 200);
            productosListView.Columns.Add("Precio unitario", 200);
            productosListView.Columns.Add("Descuento", 200);
            productosListView.Columns.Add("Precio Total", 200);
            productosListView.Columns.Add("Fecha de creación", 200);

            //Lista de productos
            var products = ProductService.GetInstance().GetAll().Data;

            // Verificar si la lista de productos está vacía
            if (!products.Any())
            {
                ListViewItem item = new ListViewItem("No hay productos activos en este momento.");
                productosListView.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var value in products)
                {
                    ListViewItem item = new ListViewItem(value.Id.ToString());

                    item.SubItems.Add(value.Stock.ToString());
                    item.SubItems.Add(value.Name);
                    item.SubItems.Add(value.Description);
                    item.SubItems.Add(value.UnitPrice.ToString("N0"));
                    item.SubItems.Add(value.Discount.ToString());
                    item.SubItems.Add(value.TotalPrice.ToString("N0"));
                    item.SubItems.Add(value.CreateAt.ToShortDateString());

                    productosListView.Items.Add(item);
                }
            }
        }

        //Cargar datos a la Lista de ventas
        private void LoadDataToSalesList()
        {
            salesListView.Columns.Add("ID", 100);
            salesListView.Columns.Add("Precio Total", 100);
            salesListView.Columns.Add("Estado", 200);
            salesListView.Columns.Add("Ciudad de entrega", 200);
            salesListView.Columns.Add("Dirección de entrega", 200);
            salesListView.Columns.Add("Fecha de creación", 200);
            salesListView.Columns.Add("Identificación del cliente", 200);

            // Obtener el ID del usuario actual
            var userId = AuthService.User.Id;

            // Lista de ventas del usuario actual
            var sales = SaleService.GetInstance().GetAll().Data.Where(sale => sale.User.Id == userId);

            // Verificar si la lista de ventas está vacía
            if (!sales.Any())
            {
                ListViewItem item = new ListViewItem("No hay ventas activas en este momento.");
                salesListView.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var sale in sales)
                {
                    ListViewItem item = new ListViewItem(sale.Id.ToString());

                    item.SubItems.Add(sale.TotalPrice.ToString("N0"));
                    item.SubItems.Add(sale.Status.Name);
                    item.SubItems.Add(sale.Location.City.Name);
                    item.SubItems.Add(sale.Location.Address);
                    item.SubItems.Add(sale.CreateAt.ToShortDateString());
                    item.SubItems.Add(sale.User.Id.ToString());

                    salesListView.Items.Add(item);
                }
            }
        }

        //Cargar datos a la lista de detalles de venta / Carrito de compra
        private void LoadDataToSaleDetailsList()
        {
            saleDetailsListView.Columns.Add("Nombre del producto", 100);
            saleDetailsListView.Columns.Add("Cantidad", 200);
            saleDetailsListView.Columns.Add("Subtotal", 200);
            saleDetailsListView.Columns.Add("Fecha de creación", 200);

            // Verificar si la lista de productos está vacía
            if (!SaleDetails.Any())
            {
                ListViewItem item = new ListViewItem("No hay productos activos en este momento.");
                saleDetailsListView.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var sale in SaleDetails)
                {
                    ListViewItem item = new ListViewItem(sale.Product.Name); // Usar el contador como el primer subitem
                    item.SubItems.Add(sale.Quantity.ToString());
                    item.SubItems.Add(sale.Subtotal.ToString("N0"));
                    item.SubItems.Add(sale.CreateAt.ToShortDateString());

                    saleDetailsListView.Items.Add(item);
                }
            }
        }

        //Actualizar lista de detalles de la venta / carrito de compra
        private void RefreshSaleDetailsList()
        {
            // Limpia la lista de detalles de la venta
            saleDetailsListView.Items.Clear();

            // Verificar si la lista de productos está vacía
            if (!SaleDetails.Any())
            {
                ListViewItem item = new ListViewItem("No hay productos activos en este momento.");
                saleDetailsListView.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var sale in SaleDetails)
                {
                    ListViewItem item = new ListViewItem(sale.Product.Name);
                    item.SubItems.Add(sale.Quantity.ToString());
                    item.SubItems.Add(sale.Subtotal.ToString());
                    item.SubItems.Add(sale.CreateAt.ToShortDateString());

                    saleDetailsListView.Items.Add(item);
                }
            }
        }

        //Actualizar lista de detalles de la venta / carrito de compra
        private void RefreshSaleList()
        {
            // Limpia la lista de detalles de la venta
            salesListView.Items.Clear();

            // Obtener el ID del usuario actual
            var userId = AuthService.User.Id;

            // Lista de ventas del usuario actual
            var sales = SaleService.GetInstance().GetAll().Data.Where(sale => sale.User.Id == userId);

            // Verificar si la lista de ventas está vacía
            if (!sales.Any())
            {
                ListViewItem item = new ListViewItem("No hay ventas activas en este momento.");
                salesListView.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var sale in sales)
                {
                    ListViewItem item = new ListViewItem(sale.Id.ToString());

                    item.SubItems.Add(sale.TotalPrice.ToString("N0"));
                    item.SubItems.Add(sale.Status.Name);
                    item.SubItems.Add(sale.Location.City.Name);
                    item.SubItems.Add(sale.Location.Address);
                    item.SubItems.Add(sale.CreateAt.ToShortDateString());
                    item.SubItems.Add(sale.User.Id.ToString());

                    salesListView.Items.Add(item);
                }
            }
        }

        //--------------------- Productos CRUD  --------------------------------//
        private void productosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productosListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selectedItem = productosListView.SelectedItems[0];
            int productId = int.Parse(selectedItem.SubItems[0].Text);
            Product product = ProductService.GetInstance().GetById(productId).Data;

            if (product.Image != null)
            {
                using (var ms = new MemoryStream(product.Image))
                {
                    productImgPctrBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                productImgPctrBox.Image = null;
            }
        }
        //--------------------- Productos CRUD  --------------------------------//

        //--------------------- Ventas CRUD  --------------------------------//
        private void createDetailsBtn_Click(object sender, EventArgs e)
        {
            CreateDetails createDetails = new CreateDetails();
            createDetails.SaleDetailsCreated += RefreshSaleDetailsList;
            createDetails.Show();
        }

        private void cleanCartBtn_Click(object sender, EventArgs e)
        {
            SaleDetails.Clear();
            RefreshSaleDetailsList();
        }

        private void createSaleBtn_Click(object sender, EventArgs e)
        {
            if (!SaleDetails.Any())
            {
                MessageBox.Show("Debe realizar ventas o detalles de la venta primeramente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateSale createSale = new CreateSale();
            createSale.SaleCreated += RefreshSaleList;
            createSale.SaleCreated += RefreshSaleDetailsList;
            createSale.Show();
        }

        //--------------------- Ventas CRUD  --------------------------------//

        private void userIconBtn_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
        }
    }
}
