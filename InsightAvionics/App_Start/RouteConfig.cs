using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InsightAvionics
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "ProductCreate",
               url: "Products/Create",
               defaults: new { controller = "Products", action = "Create" }
           );

            routes.MapRoute(
               name: "Product",
               url: "Products/{shortname}",
               defaults: new { controller = "Products", action = "Short"}
           );

            routes.MapRoute(
               name: "SideProduct",
               url: "SideProducts/{sideshort}",
               defaults: new { controller = "SideProducts", action = "Short" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
