using BLL.Services;
using GUI.Config.Theme;
using MaterialSkin.Controls;

namespace GUI.Forms.Users;

public partial class UserProfile : MaterialForm
{
    public UserProfile()
    {
        InitializeComponent();
        ThemeManager.ConfigureTheme(this);

        var user = AuthService.User;

        idNumberTxt.Text = user.IdentityCard;
        namesTxt.Text = user.Names;
        surnamesTxt.Text = user.Surnames;
        phoneNumberTxt.Text = user.Phone;
        emailNumberTxt.Text = user.Email;
        usernameTxt.Text = user.Username;
        createdAtTxt.Text = user.CreateAt.ToShortDateString();

        usernameTxt.Enabled = false;
        createdAtTxt.Enabled = false;
        namesTxt.Enabled = false;
        surnamesTxt.Enabled = false;
        phoneNumberTxt.Enabled = false;
        idNumberTxt.Enabled = false;
        emailNumberTxt.Enabled = false;

    }
}