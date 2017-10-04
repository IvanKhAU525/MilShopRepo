using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MilShop.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "",
                defaults: new {controller = "Home", action = "Index"}
                );

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { controller = "Home", action = "Index", category = (string)null },
                constraints: new { page = @"\d+" });

            routes.MapRoute(
                name: null,
                url: "{category}",
                defaults: new { controller = "Home", action = "Index" });

            routes.MapRoute(
                name: null,
                url: "{category}/Page{page}",
                defaults: new { controller = "Home", action = "Index" },
                constraints: new { page = @"\d+" });

            routes.MapRoute(
                name: "",
                url: "{controller}/{action}");
        }
    }
}
