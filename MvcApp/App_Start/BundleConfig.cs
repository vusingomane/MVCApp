using System.Web;
using System.Web.Optimization;


namespace MvcApp
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //BundleTable.EnableOptimizations = true; // when this is not false
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.css") // will look for bootstrap.min.css
                .Include("~/Content/site.css") // will look for site.min.css
                .Include("~/Content/bootstrap-switch.css") // will look for bootstrap-switch.min.css
                .Include("~/Content/datepicker.css") // will look for datepicker.min.css
                .Include("~/Content/bootstrap-duallistbox.css") // will look for bootstrap-duallistbox.min.css
                .Include("~/Content/bootstrap-datepicker3.css")
                .Include("~/Content/bootstrap-datetimepicker.min.css")
                .Include("~/Content/fullcalender.css") // will look for fullcalender.min.css
                .Include("~/Content/fullcalender.print.css")
            ); // will look for fullcalender.print.min.css

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
              "~/Scripts/bootstrap.js",
              "~/Scripts/bootstrap-datepicker.js",
              "~/Scripts/DatePickerReady.js",
              "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));
            // Code removed for clarity.            
        }
    }
}