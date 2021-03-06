﻿using System.Web;
using System.Web.Optimization;

namespace GravesConsultingLLC.RiskManager.Administration
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.min.css",  
                    "~/Content/Site.css",
                    "~/Content/angular.treeview.css",
                    "~/Content/loading-bar.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                    "~/Scripts/angular.min.js",
                    "~/Scripts/angular-route.min.js",
                    "~/Scripts/angular.treeview.min.js",
                    "~/Scripts/loading-bar.min.js",
                    "~/Scripts/angular-modal-service.min.js",
                    "~/Scripts/App/RiskManager.App.js",
                    "~/Scripts/App/RiskManager.Controller.js",
                    "~/Scripts/App/RiskManager.Controller.Service.js"
                ));
        }
    }
}
