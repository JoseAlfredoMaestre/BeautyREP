using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BLL.Services;
using Entities.Models;
using GUI.Forms.Users;

namespace GUI.Forms
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

            materialListView1.Columns.Add("ID", 50);
            materialListView1.Columns.Add("Nombres", 200);
            materialListView1.Columns.Add("Apellidos", 200);
            materialListView1.Columns.Add("Telefono", 200);
            materialListView1.Columns.Add("Correo", 300);
            materialListView1.Columns.Add("Fecha de creación", 300);

            //Datos de prueba
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
                    item.SubItems.Add(value.CreateAt.ToShortTimeString());

                    materialListView1.Items.Add(item);
                }
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.UserCreated += RefreshUserList;
            createUser.Show();
        }

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
                    item.SubItems.Add(value.CreateAt.ToShortTimeString());

                    materialListView1.Items.Add(item);
                }
            }
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
            foreach (ListViewItem item in materialListView1.SelectedItems)
            {
                int userId = int.Parse(item.SubItems[0].Text);
                User user = UserService.GetInstance().GetById(userId).Data;

                UpdateUser updateUser = new UpdateUser(user);
                updateUser.UserUpdated += RefreshUserList;
                updateUser.Show();
            }
        }
    }
}
