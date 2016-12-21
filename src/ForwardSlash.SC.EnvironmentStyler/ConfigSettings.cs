
namespace ForwardSlash.SC.EnvironmentStyler
{
    public class ConfigSettings
    {
        public static string CssFile
        {
            get
            {
                return Sitecore.Configuration.Settings.GetSetting("FS.EnvironmentStyler.CssFile");
            }
        }

        public static string Paths
        {
            get
            {
                return Sitecore.Configuration.Settings.GetSetting("FS.EnvironmentStyler.Paths");
            }
        }
    }
}