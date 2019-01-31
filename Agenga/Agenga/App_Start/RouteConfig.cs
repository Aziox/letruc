using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Agenga
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //je ne suis pas sur de moi du tout

            routes.MapRoute(
                name: "Broker",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Broker", action = "addBroker", id = UrlParameter.Optional }
                );
        }
    }
}
