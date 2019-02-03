using System.Web;
using System.Web.Optimization;

namespace Hms
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bootstrap/css").Include("~/Theme/css/bootstrap.css"));
            bundles.Add(new StyleBundle("~/fonts/css").Include("~/Theme/fonts/icomoon.css",
                                                               "~/Theme/fonts/flag-icon-css/css/flag-icon.min.css",
                                                               "~/Theme/vendors/css/pace.css"));
            bundles.Add(new StyleBundle("~/robust/css").Include("~/Theme/css/bootstrap-extended.css",
                                                                "~/Theme/css/app.css",
                                                                "~/Theme/css/colors.css"));
            bundles.Add(new StyleBundle("~/page/css").Include("~/Theme/css/core/menu/menu-types/vertical-menu.css",
                                                              "~/Theme/css/core/menu/menu-types/vertical-overlay-menu.css",
                                                              "~/Theme/css/core/colors/palette-gradient.css",
                                                               "~/Theme/vendors/css/datedropper.css"));
            bundles.Add(new StyleBundle("~/custom/css").Include("~/Theme/css/style.css"));

            bundles.Add(new ScriptBundle("~/script/js").Include("~/Theme/js/core/libraries/jquery.js",
                                                                "~/Theme/vendors/js/ui/tether.js",
                                                                "~/Theme/js/core/libraries/bootstrap.js",
                                                                "~/Theme/vendors/js/ui/perfect-scrollbar.jquery.js",
                                                                "~/Theme/vendors/js/ui/unison.js",
                                                                "~/Theme/vendors/js/ui/blockUI.js",
                                                                "~/Theme/vendors/js/ui/jquery.matchHeight.js",
                                                                "~/Theme/vendors/js/ui/screenfull.min.js",
                                                                "~/Theme/vendors/js/extensions/pace.min.js",
                                                                "~/Theme/vendors/js/datedropper.js"));
            bundles.Add(new ScriptBundle("~/robust/js").Include("~/Theme/js/core/app-menu.js",
                                                                "~/Theme/js/core/app.js"));
            bundles.Add(new ScriptBundle("~/page/js").Include("~/Theme/js/scripts/pages/dashboard-lite.js"));
        }
    }
}
