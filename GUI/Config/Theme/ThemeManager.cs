using MaterialSkin.Controls;
namespace GUI.Config.Theme;

public static class ThemeManager
{
    public static void ConfigureTheme(MaterialForm form)
    {
        var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        materialSkinManager.AddFormToManage(form);
        materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
            MaterialSkin.Primary.BlueGrey800,
            MaterialSkin.Primary.BlueGrey900,
            MaterialSkin.Primary.BlueGrey500,
            MaterialSkin.Accent.LightBlue200,
            MaterialSkin.TextShade.WHITE
        );
    }
}