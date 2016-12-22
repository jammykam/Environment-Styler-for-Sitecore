
namespace ForwardSlash.SC.EnvironmentStyler
{
    public class ConfigSettings
    {
        public static string CssFile => Sitecore.Configuration.Settings.GetSetting("FS.EnvironmentStyler.CssFile");
        public static string Paths => Sitecore.Configuration.Settings.GetSetting("FS.EnvironmentStyler.Paths");
    }
}