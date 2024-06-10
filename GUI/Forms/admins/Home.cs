using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Forms.admins.Cities;
using GUI.Forms.admins.Products;
using GUI.Forms.admins.Users;
using GUI.Forms.Users;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI.Forms.admins
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            LoadDataToUserList();
            LoadDataToCitiesList();
            LoadDataToProductsList();
        }

        //Cargar datos a la lista de usuarios
        private void LoadDataToUserList()
        {
            materialListView1.Columns.Add("ID", 50);
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

        //Actualizar lista de usuarios
        private void RefreshUserList()
        {
            // Limpia la lista de usuarios
            materialListView1.Items.Clear();

            // Recarga la lista de usuarios
            var usuarios = UserService.GetInstance().GetAll().Data;

            if (!usuarios.Any())
            {
                ListViewItem item = new ListViewItem("No hay datos");
                materialListView1.Items.Add(item);
            }
            else
            {
                foreach (var value in usuarios)
                {
                    ListViewItem item = new ListViewItem();

                    item.SubItems[0].Text = value.Id.ToString();
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

        //--------------------- Usuario CRUD  --------------------------------//

        private void materialButton1_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.UserCreated += RefreshUserList;
            createUser.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Por favor, seleccione un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, seleccione una ciudad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, seleccione una ciudad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
