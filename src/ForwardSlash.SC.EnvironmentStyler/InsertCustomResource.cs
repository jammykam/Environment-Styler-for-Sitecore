using System;
using System.Web.UI;
using Sitecore.StringExtensions;
using Sitecore.Web.UI.HtmlControls;

namespace ForwardSlash.SC.EnvironmentStyler
{
    public class InsertCustomResource : Sitecore.Layouts.PageExtenders.PageExtender
    {
        private const string StylesheetLinkTag = "<link href=\"{0}\" rel=\"stylesheet\" />";
        private string _cssFile, _urlPaths;

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
            
            if (Sitecore.Context.Items["sc_pagescriptmanager"] != null)
            {
                PageScriptManager.Current.StylesheetFiles.Add(new StylesheetFile {Src = _cssFile});
                return;
            }
            
            if (Sitecore.Context.Page.Page.Controls.Count > 0)
            {
                var control = new LiteralControl(StylesheetLinkTag.FormatWith(_cssFile));
                
                foreach (System.Web.UI.Control pageControl in Sitecore.Context.Page.Page.Controls)
                {
                    if (pageControl is System.Web.UI.HtmlControls.HtmlHead)
                    {
                        pageControl.Controls.Add(control);
                    }
                }
            }
        }
    }
}