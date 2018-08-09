using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VietGearStore._1511060754
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Category", "{type}/{meta}",
            new { controller = "Product", action = "Index", meta = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "type", "danh-muc" }
            },
            namespaces: new[] { "VietGearStore.1511060754.Controllers" });

            routes.MapRoute("Tintuc", "{type}",
            new { controller = "Tintuc", action = "Index", id = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "type", "tin-tuc" }
            },
             namespaces: new[] { "VietGearStore.1511060754.Controllers" });

            routes.MapRoute("Gioithieu", "{type}",
            new { controller = "Gioithieu", action = "Index", id = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "type", "gioi-thieu" }
            },
             namespaces: new[] { "VietGearStore.1511060754.Controllers" });

            routes.MapRoute("Lienhe", "{type}",
            new { controller = "Lienhe", action = "Create", id = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "type", "lien-he" }
            },
             namespaces: new[] { "VietGearStore.1511060754.Controllers" });

            routes.MapRoute("Detail", "{type}/{meta}-{id}",
              new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
              new RouteValueDictionary
              {
                { "type", "san-pham" }
              },
                namespaces: new[] { "VietGearStore.1511060754.Controllers" });

            routes.MapRoute("Detailnews", "{type}/{meta}",
                new { controller = "Tintuc", action = "Detailnews", meta = UrlParameter.Optional },
                new RouteValueDictionary
                {
                    { "type", "tin-tuc" }
                },
                namespaces: new[] { "VietGearStore.1511060754.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "VietGearStore.1511060754.Controllers" }
            );
        }
    }
}
