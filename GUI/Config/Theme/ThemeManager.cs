using System.Windows.Forms;
using MaterialSkin.Controls;
namespace GUI.Config.Theme;

public static class ThemeManager
{
    public static void ConfigureTheme(MaterialForm form)
    {
        form.StartPosition = FormStartPosition.CenterScreen;
        var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.AddFormToManage(form);
        materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
            MaterialSkin.Primary.Pink800,
            MaterialSkin.Primary.Pink900,
            MaterialSkin.Primary.Pink500,
            MaterialSkin.Accent.Pink200,
            MaterialSkin.TextShade.WHITE
        );
    }
}