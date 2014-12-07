using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Test3
{
    public class RouteConfig
    {
        private static readonly string[] Namespaces = new[] { "Test3.Controllers" };
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Comments",
                url: "comment-{seoUrl}",
                defaults: new { controller = "BlogPost", action = "BlogPost", seoUrl = string.Empty}
            );

            routes.MapRoute(
                name: "Contact",
                url: "contact-{seoUrl}",
                defaults: new { controller = "Contact", action = "Contact", seoUrl = string.Empty }
            );

            routes.MapRoute(
              name: "Gallary",
              url: "gallary-{seoUrl}",
              defaults: new { controller = "Gallary", action = "Gallary", seoUrl = string.Empty }
          );

            routes.MapRoute(
              name: "About",
              url: "about-{seoUrl}",
              defaults: new { controller = "About", action = "About", seoUrl = string.Empty }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                , namespaces: Namespaces
            );
        }
    }
}