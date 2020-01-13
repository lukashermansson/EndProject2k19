﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SlutProjekt2k19 {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                //routeTemplate: "api/{controller}/{id}",
                defaults: new {
                    id = RouteParameter.Optional
                }
            );
        }
    }
}