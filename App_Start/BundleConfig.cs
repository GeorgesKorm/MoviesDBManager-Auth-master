﻿using MoviesDBManager.Models;
using System.Security.Cryptography;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace MoviesDBManager
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/partialRefresh.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/session.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery.validate*",
                       "~/Scripts/jquery-ui.js",
                       "~/Scripts/imageControl-2.0.js",
                       "~/Scripts/selectionControl.js",
                       "~/Scripts/SiteScripts.js",
                       "~/Scripts/session.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/jquery-ui.css",
                     "~/Content/jquery-ui.strucure.css",
                     "~/Content/jquery-ui.theme.css",
                     "~/Content/popup.css",
                     "~/Content/selectionControl.css",
                     "~/Content/site.css"));
        }
    }
}
