using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using BLL.Services;
using Entities.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI.Forms.admins.Users
{
    public partial class UpdateUser : MaterialForm
    {
        private User _userToUpdate;
        public event Action UserUpdated;

        public UpdateUser(User user)
        {
            this._userToUpdate = user;
            InitializeComponent();

            // Poner los valores del usuario en los campos de entrada
            cedulaInput.Text = user.IdentityCard;
            nameInput.Text = user.Names;
            surnamesInput.Text = user.Surnames;
            phoneInput.Text = user.Phone;
            emailInput.Text = user.Email;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            _userToUpdate.IdentityCard = cedulaInput.Text;
            _userToUpdate.Names = nameInput.Text;
            _userToUpdate.Surnames = surnamesInput.Text;
            _userToUpdate.Phone = phoneInput.Text;
            _userToUpdate.Email = emailInput.Text;
            _userToUpdate.Username = "usuariodeprueba";
            _userToUpdate.Password = "contraseñadeprueba";

            if (_userToUpdate != null)
            {
                ValidationContext context = new(_userToUpdate, null, null);

                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(_userToUpdate, context, errors, true))
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
                    UserService.GetInstance().Update(_userToUpdate);
                    MessageBox.Show("Usuario actualizado correctamente.");
                    UserUpdated?.Invoke();
                    this.Dispose();
                }
            }
        }
    }
}
