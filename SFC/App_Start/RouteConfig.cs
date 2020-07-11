﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SFC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "pay",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Payment", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Manager",
                url: "{Manager}/{action}/{id}",
                defaults: new { controller = "Manager", action = "Idnex", id = UrlParameter.Optional }
            );

        }
    }
}
