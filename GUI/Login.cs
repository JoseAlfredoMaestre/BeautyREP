using System;
using System.Windows.Forms;
using GUI.Config.Theme;
using MaterialSkin;
using MaterialSkin.Controls;
using BLL.Services;
using Entities.Models;
using Entities.Shared;
using GUI.Forms.admins;
using GUI.Forms.Users;

namespace GUI
{
    public partial class Login : MaterialForm
    {
        AuthService _authService = new();

        public Login()
        {
            InitializeComponent();
            ThemeManager.ConfigureTheme(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Username = usernameInput.Text,
                Password = passwordInput.Text
            };

            // Llamar al método Auth
            Response<string> response = _authService.Auth(person);
            Home home = new();
            UserHome userHome = new();
            // Ahora puedes verificar la respuesta, en este caso
            //Si el inicio de sesion es exitoso, se muestra la ventana correspondiente
            if (response.IsSuccess)
            {
                //Si el rol del usuario asignado es admin, muestre admin
                if (AuthService.User?.Role == "admin") home.Show();
                //Si el rol del usuario asignado es user, muestre userHome
                if (AuthService.User?.Role == "user") userHome.Show();
                this.Hide();
            }
            else
            {
                // Hubo un error al iniciar sesión
                MessageBox.Show(response.Msg);
            }
        }
    }
}
