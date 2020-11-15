using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tienda
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Inicio",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Inicio", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tiendas",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Tiendas", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contacto",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Contacto", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
