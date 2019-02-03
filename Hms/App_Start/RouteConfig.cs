using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hms
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Rate",
            //    url:"Rate/{action}",
            //    defaults: new {controller = "Rate", action = "Index"}
            //    );

            //routes.MapRoute(
            //    name: "RateWithId",
            //    url: "Rate/UpdateRateValue/{data}",
            //    defaults: new { controller = "Rate", action = "UpdateRateValue", data=UrlParameter.Optional}
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Floor", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
