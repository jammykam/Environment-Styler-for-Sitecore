using Sitecore.Web.Pipelines.GetPageStylesheets;

namespace ForwardSlash.SC.EnvironmentStyler
{
    public class InsertCustomSpeakResource : GetPageStylesheetsProcessor
    {
        private string _cssFile;

        public InsertCustomSpeakResource()
        {
            _cssFile = ConfigSettings.CssFile;
        }

        public override void Process(GetPageStylesheetsArgs args)
        {
            args.FileNames.Add(_cssFile);
        }
    }
}