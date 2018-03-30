using System.Web;
using System.Web.Optimization;

namespace SupportEtudiant.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region JS

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // Inspinia script
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/app/inspinia.js"));

            // Inspinia plugins script
            bundles.Add(new ScriptBundle("~/bundles/inspinia/plugins").Include(
                      "~/Scripts/plugins/ChartJs/Chart.min.js",
                      "~/Scripts/plugins/chosen/chosen.jquery.js",
                      "~/Scripts/plugins/datapicker/bootstrap-datepicker.js",
                      "~/Scripts/plugins/datapicker/bootstrap-datepicker.fr.js",
                      "~/Scripts/plugins/iCheck/icheck.min.js",
                      "~/Scripts/plugins/nestable/jquery.nestable.js",
                      "~/Scripts/plugins/switchery/switchery.js",
                      "~/Scripts/plugins/toastr/toastr.min.js",
                      "~/Scripts/plugins/sumoselect/jquery.sumoselect.min.js",
                      "~/Scripts/plugins/multiselect/bootstrap-multiselect.js",
                      "~/Scripts/plugins/multiselect/bootstrap-multiselect-collapsible-groups.js",
                      "~/Scripts/plugins/jasny-bootstrap/jasny-bootstrap.js",
                      "~/Scripts/plugins/toc/toc.min.js",
                      "~/Scripts/plugins/clipboard/clipboard.min.js"
                      ));

            // tinymce
            bundles.Add(new ScriptBundle("~/bundles/tinymce").Include(
                      "~/Scripts/plugins/tinymce/tinymce.min.js"));

            // custom
            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                      "~/Scripts/morneau/supportEtudiant.js"));

            #endregion

            #region CSS

            // CSS style (bootstrap/inspinia)
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/animate.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css"));

            // Plugins
            bundles.Add(new StyleBundle("~/Content/all-plugins").Include(
                      "~/Content/plugins/datapicker/datepicker3.css",
                      "~/Content/plugins/switchery/switchery.css",
                      "~/Content/plugins/toastr/toastr.min.css",
                      "~/Content/plugins/chartist/chartist.min.css",
                      "~/Content/plugins/sumoselect/sumoselect.css",
                      "~/Content/plugins/multiselect/bootstrap-multiselect.css",
                      "~/Content/plugins/jasny-bootstrap/jasny-bootstrap.css",
                      "~/Content/plugins/toc/toc.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/plugin-chosen").Include(
                      "~/Content/plugins/chosen/chosen.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Content/plugin-iCheck").Include(
                      "~/Content/plugins/iCheck/custom.css", new CssRewriteUrlTransform()));

            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/fonts/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));
            #endregion


        }
    }
}