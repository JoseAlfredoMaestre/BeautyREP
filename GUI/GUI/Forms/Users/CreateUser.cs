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

namespace GUI.Forms.Users
{
    public partial class CreateUser : MaterialForm
    {
        public event Action UserCreated;
        public CreateUser()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string cedula = cedulaInput.Text;
            string names = nameInput.Text;
            string surnames = surnamesInput.Text;
            string phone = phoneInput.Text;
            string email = emailInput.Text;
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            var lastUser = UserService.GetInstance().GetAll().Data.LastOrDefault();
            int newId = (int)((lastUser != null) ? lastUser.Id + 1 : 1);
            var user = new User(cedula, names, surnames, phone, email, username, password); UserService.GetInstance().Save(user);

            this.Dispose();
            UserCreated?.Invoke();
        }
    }
}
