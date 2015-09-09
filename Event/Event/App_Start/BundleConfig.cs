using System.Web;
using System.Web.Optimization;

namespace Event
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            // amelia
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/superhero.css",
                      "~/Content/site.css"));
            // datepicker
            bundles.Add(new ScriptBundle("~/bundles/date").Include(
                     "~/Scripts/bootstrap-datepicker.js"));
            bundles.Add(new StyleBundle("~/Content/date").Include(
                     "~/Content/bootstrap-datepicker.css"));
            // Bootstrap.v3.Datetimepicker
            bundles.Add(new ScriptBundle("~/bundles/date3").Include(
                  "~/Scripts/moment-with-locales.min.js").Include("~/Scripts/bootstrap-datetimepicker.js"));
            bundles.Add(new StyleBundle("~/Content/date3").Include(
                     "~/Content/bootstrap-datetimepicker.css"));

            bundles.Add(new ScriptBundle("~/bundles/unify").Include(
                     "~/Scripts/jquery.cslider.js"));
        }
    }
}
