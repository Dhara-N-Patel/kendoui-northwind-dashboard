using System.Web;
using System.Web.Optimization;

namespace Pennvest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/Content/font-awesome.css",
                        "~/Content/font-awesome.min.css",
                      "~/Content/site.css"));

            //Kendo UI JS bundle
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
               "~/Scripts/kendo/kendo.all.min.js",
                "~/Scripts/kendo/kendo.grid.min.js",// Grid
                "~/Scripts/kendo/kendo.datepicker.min.js",//Date Picker
                "~/Scripts/kendo/kendo.timezones.min.js", //As I am using Scheduler
                "~/Scripts/kendo/kendo.tabstrip.min.js",//Tab Strip
                "~/Scripts/kendo/kendo.listview.min.js",//List view
                "~/Scripts/kendo/kendo.dropdownlist.min.js",//Dropdown List
                "~/Scripts/kendo/kendo.tooltip.min.js",//tool Tip
                "~/Scripts/kendo/kendo.scheduler.min.js",//Schedular
                "~/Scripts/kendo/kendo.validator.min.js",//Validator
                "~/Scripts/kendo/kendo.aspnetmvc.min.js"));

            //Kendo UI Style bundle
            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
               "~/Content/kendo/kendo.common-bootstrap.min.css",
               "~/Content/kendo/kendo.bootstrap.min.css"));

            //Tell the ASP.NET bundles to allow minified files in debug mode.
            bundles.IgnoreList.Clear();
        }
    }
}
