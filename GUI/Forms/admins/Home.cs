using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using GUI.Forms.admins.Cities;
using GUI.Forms.admins.Products;
using GUI.Forms.admins.Sales;
using GUI.Forms.admins.Users;
using GUI.Forms.Users;
using MaterialSkin.Controls;
using CreateDetails = GUI.Forms.admins.Sales.CreateDetails;
using CreateSale = GUI.Forms.admins.Sales.CreateSale;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI.Forms.admins
{
    public partial class Home : MaterialForm
    {
        public HashSet<SaleDetail> SaleDetails;
        private static Home _instance;
        private bool isInactive = true;

        public static Home GetInstance()
        {
            return _instance ??= new Home();
        }

        public Home()
        {
            ThemeManager.ConfigureTheme(this);
            _instance = this;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            SaleDetails = new();
            this.FormClosed += MainForm_FormClosed;

            LoadDataToUserList();
            LoadDataToCitiesList();
            LoadDataToProductsList();
            LoadDataToSalesList();
            LoadDataToSaleDetailsList();

            LoadDataChartPai();
            LoadDataChartColumn();
            createSaleBtn.Enabled = false;
            cleanCartBtn.Enabled = false;
        }

        public void SaleTableEnabled(bool option = true)
        {
            if (isInactive == option) return;
            isInactive = option;
            SaleDetails.Clear();
            RefreshSaleDetailsList();
            txtValue.Text = @"0 $";
            salesListView.Enabled = option;
            deleteSaleBtn.Enabled = option;
            createSaleBtn.Enabled = !option;
            cleanCartBtn.Enabled = !option;
        }
        //Cargar datos a la lista de usuarios
        private void LoadDataToUserList()
        {
            materialListView1.Columns.Add("Id", 100);
            materialListView1.Columns.Add("Cedula", 100);
            materialListView1.Columns.Add("Nombres", 200);
            materialListView1.Columns.Add("Apellidos", 200);
            materialListView1.Columns.Add("Telefono", 200);
            materialListView1.Columns.Add("Correo", 300);
            materialListView1.Columns.Add("Fecha de creación", 300);
            //Lista de usuarios
            var usuarios = UserService.GetInstance().GetAll().Data;

            // Verificar si la lista de usuarios está vacía
            if (!usuarios.Any())
            {
                ListViewItem item = new ListViewItem("No hay usuarios activos en este momento.");
                materialListView1.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var value in usuarios)
                {
                    ListViewItem item = new ListViewItem();

                    item.SubItems[0].Text = value.Id.ToString();
                    item.SubItems.Add(value.IdentityCard);
                    item.SubItems.Add(value.Names);
                    item.SubItems.Add(value.Surnames);
                    item.SubItems.Add(value.Phone);
                    item.SubItems.Add(value.Email);
                    item.SubItems.Add(value.CreateAt.ToShortDateString());

                    materialListView1.Items.Add(item);
                }
            }
        }

        //Cargar datos a la Lista de ciudades
        private void LoadDataToCitiesList()
        {
            ciudadesListView.Columns.Add("ID", 50);
            ciudadesListView.Columns.Add("Nombre", 400);
            ciudadesListView.Columns.Add("Descripcion", 400);
            ciudadesListView.Columns.Add("Fecha de creación", 400);

            //Lista de usuarios
            var ciudades = CityService.GetInstance().GetAll().Data;

            // Verificar si la lista de usuarios está vacía
            if (!ciudades.Any())
            {
                ListViewItem item = new ListViewItem("No hay ciudades activas en este momento.");
                ciudadesListView.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var value in ciudades)
                {
                    ListViewItem item = new ListViewItem();

                    item.SubItems[0].Text = value.Id.ToString();
                    item.SubItems.Add(value.Name);
                    item.SubItems.Add(value.Description);
                    item.SubItems.Add(value.CreateAt.ToShortDateString());

                    ciudadesListView.Items.Add(item);
                }
            }
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
            salesListView.Columns.Add("Ciudad de entrega", 200);
            salesListView.Columns.Add("Dirección de entrega", 200);
            salesListView.Columns.Add("Fecha de creación", 200);
            salesListView.Columns.Add("Identificación del cliente", 200);


            //Lista de productos
            var sales = SaleService.GetInstance().GetAll().Data;

            // Verificar si la lista de productos está vacía
            if (!sales.Any())
            {
                ListViewItem item = new ListViewItem("No hay productos activos en este momento.");
                salesListView.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var sale in sales)
                {
                    ListViewItem item = new ListViewItem(sale.Id.ToString());

                    item.SubItems.Add(sale.TotalPrice.ToString("N0"));
                    item.SubItems.Add(sale.Location.City.Name);
                    item.SubItems.Add(sale.Location.Address);
                    item.SubItems.Add(sale.CreateAt.ToShortDateString());
                    item.SubItems.Add(sale.User.IdentityCard);

                    salesListView.Items.Add(item);
                }
            }
        }

        //Cargar datos a la lista de detalles de venta / Carrito de compra
        private void LoadDataToSaleDetailsList()
        {
            saleDetailsListView.Columns.Add("Nombre del producto", 170);
            saleDetailsListView.Columns.Add("Cantidad", 90);
            saleDetailsListView.Columns.Add("Subtotal", 90);
            saleDetailsListView.Columns.Add("Fecha de creación", 170);

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

        //Actualizar lista de usuarios
        private void RefreshUserList()
        {
            // Limpia la lista de usuarios
            materialListView1.Items.Clear();

            // Recarga la lista de usuarios
            var usuarios = UserService.GetInstance().GetAll().Data;

            // Verificar si la lista de usuarios está vacía
            if (!usuarios.Any())
            {
                ListViewItem item = new ListViewItem("No hay usuarios activos en este momento.");
                materialListView1.Items.Add(item);
            }
            else
            {
                // Agregar datos a la lista
                foreach (var value in usuarios)
                {
                    ListViewItem item = new ListViewItem();

                    item.SubItems[0].Text = value.Id.ToString();
                    item.SubItems.Add(value.IdentityCard);
                    item.SubItems.Add(value.Names);
                    item.SubItems.Add(value.Surnames);
                    item.SubItems.Add(value.Phone);
                    item.SubItems.Add(value.Email);
                    item.SubItems.Add(value.CreateAt.ToShortDateString());

                    materialListView1.Items.Add(item);
                }
            }
        }

        //Actualizar lista de ciudades
        private void RefreshCityList()
        {
            // Limpia la lista de usuarios
            ciudadesListView.Items.Clear();

            // Recarga la lista de usuarios
            var cities = CityService.GetInstance().GetAll().Data;

            if (!cities.Any())
            {
                ListViewItem item = new ListViewItem("No hay datos");
                ciudadesListView.Items.Add(item);
            }
            else
            {
                foreach (var value in cities)
                {
                    ListViewItem item = new ListViewItem();

                    item.SubItems[0].Text = value.Id.ToString();
                    item.SubItems.Add(value.Name);
                    item.SubItems.Add(value.Description);
                    item.SubItems.Add(value.CreateAt.ToShortDateString());

                    ciudadesListView.Items.Add(item);
                }
            }
        }

        //Actualizar lista de ciudades
        private void RefreshProductsList()
        {
            // Limpia la lista de usuarios
            productosListView.Items.Clear();

            // Recarga la lista de usuarios
            var products = ProductService.GetInstance().GetAll().Data;

            if (!products.Any())
            {
                ListViewItem item = new ListViewItem("No hay datos");
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

        //Actualizar lista de detalles de la venta / carrito de compra
        public void RefreshSaleDetailsList()
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

            //Lista de productos
            var sales = SaleService.GetInstance().GetAll().Data;

            // Verificar si la lista de productos está vacía
            if (!sales.Any())
            {
                ListViewItem item = new ListViewItem("No hay productos activos en este momento.");
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

        //--------------------- Usuario CRUD  --------------------------------//

        private void materialButton1_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.UserCreated += RefreshUserList;
            createUser.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in materialListView1.SelectedItems)
            {
                int userId = int.Parse(item.SubItems[0].Text);
                User user = UserService.GetInstance().GetById(userId).Data;

                DeleteUser deleteUser = new DeleteUser(user);
                deleteUser.UserDeleted += RefreshUserList;
                deleteUser.Show();
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in materialListView1.SelectedItems)
            {
                int userId = int.Parse(item.SubItems[0].Text);
                User user = UserService.GetInstance().GetById(userId).Data;

                UpdateUser updateUser = new UpdateUser(user);
                updateUser.UserUpdated += RefreshUserList;
                updateUser.Show();
            }
        }

        //--------------------- Usuario CRUD  --------------------------------//

        //--------------------- Ciudad CRUD  --------------------------------//
        private void agregarCiudadBtn_Click(object sender, EventArgs e)
        {
            CreateCity createCity = new CreateCity();
            createCity.CityCreated += RefreshCityList;
            createCity.Show();
        }

        private void eliminarCiudadBtn_Click(object sender, EventArgs e)
        {
            if (ciudadesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una ciudad.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in ciudadesListView.SelectedItems)
            {
                int cityId = int.Parse(item.SubItems[0].Text);
                City city = CityService.GetInstance().GetById(cityId).Data;

                DeleteCity deleteUser = new DeleteCity(city);
                deleteUser.CityDeleted += RefreshCityList;
                deleteUser.Show();
            }
        }

        private void actualizarCiudadBtn_Click(object sender, EventArgs e)
        {
            if (ciudadesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una ciudad.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in ciudadesListView.SelectedItems)
            {
                int cityId = int.Parse(item.SubItems[0].Text);
                City city = CityService.GetInstance().GetById(cityId).Data;

                UpdateCity updateCity = new UpdateCity(city);
                updateCity.CityUpdated += RefreshCityList;
                updateCity.Show();
            }
        }
        //--------------------- Ciudad CRUD  --------------------------------//

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

        private void agregarProductoBtn_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.ProductCreated += RefreshProductsList;
            createProduct.Show();
        }

        private void eliminarProductoBtn_Click(object sender, EventArgs e)
        {
            if (productosListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in productosListView.SelectedItems)
            {
                int productId = int.Parse(item.SubItems[0].Text);
                Product product = ProductService.GetInstance().GetById(productId).Data;

                DeleteProduct deleteProduct = new DeleteProduct(product);
                deleteProduct.ProductDeleted += RefreshProductsList;
                deleteProduct.Show();
            }
        }

        private void actualizarProductoBtn_Click(object sender, EventArgs e)
        {
            if (productosListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in productosListView.SelectedItems)
            {
                int productId = int.Parse(item.SubItems[0].Text);
                Product product = ProductService.GetInstance().GetById(productId).Data;

                UpdateProduct updateProduct = new UpdateProduct(product);
                updateProduct.ProductUpdated += RefreshProductsList;
                updateProduct.Show();
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
            SaleTableEnabled(true);
            SaleDetails.Clear();
            saleDetailsListView.Clear();
            if (salesListView.SelectedItems.Count <= 0)
            {
                SaleDetails.Clear();
                RefreshSaleDetailsList();
                txtValue.Text = @"0 $";
                return;
            }
            // Obtiene el primer elemento seleccionado
            var selectedItem = salesListView.SelectedItems[0];

            // Obtiene el valor de la primera columna
            var id = long.Parse(selectedItem.SubItems[0].Text);

            // Ahora puedes usar el valor de la primera columna
            var res = SaleService.GetInstance().GetById(id);
            if (!res.IsSuccess) return;
            var sale = res.Data;
            foreach (var saleDetail in sale.SaleDetails) SaleDetails.Add(saleDetail);

            LoadDataToSaleDetailsList();
            txtValue.Text = SaleDetails.Sum(det => det.Subtotal).ToString("N0") + " $";
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

        private void deleteSaleBtn_Click(object sender, EventArgs e)
        {
            if (salesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una venta.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in salesListView.SelectedItems)
            {
                long saleId = int.Parse(item.SubItems[0].Text);

                DeleteSale deleteSale = new DeleteSale(saleId);
                deleteSale.SaleDeleted += RefreshSaleList;
                deleteSale.SaleDeleted += RefreshSaleDetailsList;
                deleteSale.Show();
            }
        }

        //--------------------- Ventas CRUD  --------------------------------//
        private void userIconBtn_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new();
            userProfile.Show();
        }

        // Configuración de la gráfica pai
        private void loadComboChartPai()
        {
            var sales = SaleService.GetInstance().GetAll().Data;
            foreach (var item in sales)
            {
                if (cbYearPai.Items.Contains(item.CreateAt.Year.ToString()) == false)
                {
                    cbYearPai.Items.Add(item.CreateAt.Year.ToString());
                }
            }
        }

        private void chartPaiConfig(Dictionary<string, int> salesPerProduct)
        {
            chartPai.Series[0].Points.Clear();
            chartPai.Legends[0].CustomItems.Clear();

            chartPai.ForeColor = Color.White;
            foreach (var kvp in salesPerProduct)
            {
                string leyenda = $"{kvp.Value} veces";
                chartPai.Series[0].Points.AddXY(kvp.Key, kvp.Value);
                chartPai.Series[0].Points.Last().LegendText = leyenda;
            }
        }

        private void LoadDataChartPai()
        {
            try
            {
                loadComboChartPai();

                if (cbYearPai.Text != "")
                {
                    chartPaiConfig(Statistics.GetInstance().GetAnnualProductSales(int.Parse(cbYearPai.Text)).Data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void cbYearPai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataChartPai();
        }

        // Configuración del histograma
        private void loadComboChartColumn()
        {
            var sales = SaleService.GetInstance().GetAll().Data;
            foreach (var item in sales)
            {
                if (cbYearColumn.Items.Contains(item.CreateAt.Year.ToString()) == false)
                {
                    cbYearColumn.Items.Add(item.CreateAt.Year.ToString());
                }
            }
        }

        private void chartColumnConfig(Dictionary<string, int> salesPerAnyMonth)
        {
            chartColumn.Series.Clear();
            Series series = new Series
            {
                Name = "Ventas",
                ChartType = SeriesChartType.Column
            };

            foreach (var kvp in salesPerAnyMonth.OrderBy(item => item.Key))
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            chartColumn.Series.Add(series);


            chartColumn.ChartAreas[0].AxisX.Interval = 1;
            chartColumn.ChartAreas[0].AxisX.Title = "Meses";
            chartColumn.ChartAreas[0].AxisY.Title = "# Ventas";
        }

        private void LoadDataChartColumn()
        {

            try
            {
                loadComboChartColumn();

                if (cbYearColumn.Text != "")
                {
                    chartColumnConfig(Statistics.GetInstance().GetMonthlySalesCount(int.Parse(cbYearColumn.Text)).Data);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void cbYearColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataChartColumn();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            AuthService auth = new();
            this.Dispose();
            auth.Logout();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar la aplicación cuando se cierre el formulario principal
            Application.Exit();
        }

        private void salesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaleDetails.Clear();
            saleDetailsListView.Clear();
            if (salesListView.SelectedItems.Count <= 0)
            {
                SaleDetails.Clear();
                RefreshSaleDetailsList();
                txtValue.Text = @"0 $";
                return;
            }
            // Obtiene el primer elemento seleccionado
            var selectedItem = salesListView.SelectedItems[0];

            // Obtiene el valor de la primera columna
            var id = long.Parse(selectedItem.SubItems[0].Text);

            // Ahora puedes usar el valor de la primera columna
            var res = SaleService.GetInstance().GetById(id);
            if (!res.IsSuccess) return;
            var sale = res.Data;
            foreach (var saleDetail in sale.SaleDetails) SaleDetails.Add(saleDetail);

            LoadDataToSaleDetailsList();
            txtValue.Text = SaleDetails.Sum(det => det.Subtotal).ToString("N0") + " $";

        }
    }
}
