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
    public partial class UpdateUser : MaterialForm
    {
        private User userToUpdate;
        public event Action UserUpdated;
        public UpdateUser(User user)
        {
            this.userToUpdate = user;
            InitializeComponent();

            // Poner los valores del usuario en los campos de entrada
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
            userToUpdate.Names = nameInput.Text;
            userToUpdate.Surnames = surnamesInput.Text;
            userToUpdate.Phone = phoneInput.Text;
            userToUpdate.Email = emailInput.Text;

            UserService.GetInstance().Update(userToUpdate);
            UserUpdated?.Invoke();
            this.Dispose();
        }
    }
}
