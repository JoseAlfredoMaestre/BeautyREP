using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using GUI.Config.Theme;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Users
{
    public partial class CreateUser : MaterialForm
    {
        public event Action UserCreated;

        public CreateUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ThemeManager.ConfigureTheme(this);
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
            User user = new User
            {
                IdentityCard = cedula,
                Names = names,
                Surnames = surnames,
                Phone = phone,
                Email = email,
                Username = username,
                Password = password,
                CreateAt = DateTime.Now
            };
            if (user != null)
            {
                ValidationContext context = new(user, null, null);

                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(user, context, errors, true))
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
                    UserService.GetInstance().Save(user);
                    this.Dispose();
                    UserCreated?.Invoke();
                }
            }
        }
    }
}