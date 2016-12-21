using System;
using System.Web.UI;
using Sitecore.StringExtensions;

namespace ForwardSlash.SC.EnvironmentStyler
{
    public class InsertCustomResource : Sitecore.Layouts.PageExtenders.PageExtender
    {
        private const string StylesheetLinkTag = "<link href=\"{0}\" rel=\"stylesheet\" />";
        private string _cssFile;
        private string _urlPaths;

        public InsertCustomResource()
        {
            _cssFile = ConfigSettings.CssFile;
            _urlPaths = ConfigSettings.Paths;
        }

        public override void Insert()
        {
            if (string.IsNullOrWhiteSpace(_cssFile) ||
                _urlPaths.IndexOf(Sitecore.Context.Page.Page.AppRelativeVirtualPath, StringComparison.InvariantCultureIgnoreCase) < 0)
            {
                return;
            }

            base.InsertControl(new LiteralControl(StylesheetLinkTag.FormatWith(_cssFile)));
        }
    }
}