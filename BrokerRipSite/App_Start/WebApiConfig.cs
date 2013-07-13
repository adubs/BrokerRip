using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BrokerRipSite
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{percentageTarget}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
