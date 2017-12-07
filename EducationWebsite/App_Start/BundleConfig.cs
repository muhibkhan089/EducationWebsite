using System.Web;
using System.Web.Optimization;

namespace EducationWebsite
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
                      "~/Content/site.css"));
            //Layout Css
            bundles.Add(new StyleBundle("~/Content/LayoutLibCss").Include(
                     "~/Content/assets/css/main.css",
                     "~/Content/assets/css/themes/all-themes.css"));
            //Layout JS
            bundles.Add(new ScriptBundle("~/bundles/LayoutLibJs").Include(
                     "~/Content/assets/bundles/libscripts.bundle.js",
                      "~/Content/assets/bundles/vendorscripts.bundle.js",
                      "~/Content/assets/bundles/mainscripts.bundle.js"));
            //Login Css
            bundles.Add(new StyleBundle("~/Content/LoginCss").Include(
                     "~/Content/assets/css/login.css"));
            //Login JS
            bundles.Add(new ScriptBundle("~/bundles/LoginJs").Include(
                    "~/Content/assets/js/pages/examples/sign-in.js"));
            //Forgot Js
            bundles.Add(new ScriptBundle("~/bundles/ForgotJs").Include(
                   "~/Content/assets/js/pages/examples/forgot-password.js"));
            //Index Css
            bundles.Add(new StyleBundle("~/Content/IndexLibCss").Include(
                     "~/Content/assets/plugins/morrisjs/morris.css"));
            //Index Js
            bundles.Add(new ScriptBundle("~/bundles/IndexLibJs").Include(
                     "~/Content/assets/plugins/jquery-sparkline/jquery.sparkline.min.js",
                      "~/Content/assets/plugins/chartjs/Chart.bundle.min.js",
                      "~/Content/assets/js/pages/charts/sparkline.min.js",
                      "~/Content/assets/js/pages/charts/chartjs.min.js",
                      "~/Content/assets/js/pages/index.js"));
            //MailBox Css
            bundles.Add(new StyleBundle("~/Content/MailLibCss").Include(
                    "~/Content/assets/css/inbox.css"));
            //MailBox Js
            bundles.Add(new ScriptBundle("~/bundles/MailLibJs").Include(
                     "~/Content/assets/js/pages/inbox/inbox.js",
                      "~/Content/assets/js/pages/index.js"));
            //Event Css
            bundles.Add(new StyleBundle("~/Content/EventLibCss").Include(
                   "~/Content/assets/plugins/fullcalendar/fullcalendar.min.css"));
            //Event Js
            bundles.Add(new ScriptBundle("~/bundles/EventLibJs").Include(
                    "~/Content/assets/bundles/fullcalendarscripts.bundle.js",
                     "~/Content/assets/js/pages/index.js",
                     "~/Content/assets/js/pages/calendar/calendar.js"));
            //Teacher Js
            bundles.Add(new ScriptBundle("~/bundles/TeacherLibJs").Include(
                      "~/Content/assets/js/pages/index.js"));
            //AddTeacher Css
            bundles.Add(new StyleBundle("~/Content/AddTeacherLibCss").Include(
                    "~/Content/assets/plugins/morrisjs/morris.css",
                    "~/Content/assets/plugins/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css",
                    "~/Content/assets/plugins/waitme/waitMe.css",
                    "~/Content/assets/plugins/bootstrap-select/css/bootstrap-select.css"));
            //AddTeacher Js
            bundles.Add(new ScriptBundle("~/bundles/AddTeacherLibJs").Include(
                   "~/Content/assets/plugins/autosize/autosize.js",
                    "~/Content/assets/plugins/momentjs/moment.js",
                    "~/Content/assets/plugins/dropzone/dropzone.js",
                    "~/Content/assets/plugins/bootstrap-material-datetimepicker/js/bootstrap-material-datetimepicker.js",
                    "~/Content/assets/js/pages/forms/basic-form-elements.js",
                    "~/Content/assets/js/pages/index.js"));
            //Library CSS
            bundles.Add(new StyleBundle("~/Content/LibraryCss").Include(
                   "~/Content/assets/plugins/jquery-datatable/skin/bootstrap/css/dataTables.bootstrap.css"));
            //Library Js
            bundles.Add(new ScriptBundle("~/bundles/LibraryJs").Include(
                   "~/Content/assets/plugins/jquery-datatable/jquery.dataTables.js",
                    "~/Content/assets/plugins/jquery-datatable/skin/bootstrap/js/dataTables.bootstrap.js",
                    "~/Content/assets/plugins/jquery-datatable/extensions/export/dataTables.buttons.min.js",
                    "~/Content/assets/plugins/jquery-datatable/extensions/export/buttons.flash.min.js",
                    "~/Content/assets/plugins/jquery-datatable/extensions/export/jszip.min.js",
                    "~/Content/assets/plugins/jquery-datatable/extensions/export/pdfmake.min.js",
                     "~/Content/assets/plugins/jquery-datatable/extensions/export/vfs_fonts.js",
                      "~/Content/assets/plugins/jquery-datatable/extensions/export/buttons.html5.min.js",
                       "~/Content/assets/plugins/jquery-datatable/extensions/export/buttons.print.min.js",
                        "~/Content/assets/js/pages/tables/jquery-datatable.js"));
            //AddLibrary Css
            bundles.Add(new StyleBundle("~/Content/AddLibraryCss").Include(
                   "~/Content/assets/plugins/bootstrap-select/css/bootstrap-select.css"));
        }
    }
}
