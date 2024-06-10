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
using GUI.Config.Theme;

namespace GUI.Forms.admins.Users
{
    public partial class DeleteUser : MaterialForm
    {
        private User userToDelete;
        public event Action UserDeleted;
        public DeleteUser(User userToDelete)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ThemeManager.ConfigureTheme(this);
            this.userToDelete = userToDelete;

            materialLabel6.Text = userToDelete.IdentityCard;
            materialLabel7.Text = userToDelete.Names;
            materialLabel8.Text = userToDelete.Surnames;
            materialLabel9.Text = userToDelete.Phone;
            materialLabel10.Text = userToDelete.Email;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            UserService.GetInstance().Delete(userToDelete.Id);
            UserDeleted?.Invoke();
            MessageBox.Show("Usuario eliminado correctamente.");
            this.Dispose();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
