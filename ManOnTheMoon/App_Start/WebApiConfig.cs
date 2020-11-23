using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.Web;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;
namespace ManOnTheMoon.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //WebApi Configuration and services

            //WEb Api routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{action}/{id}", defaults: new { id = RouteParameter.Optional });



            JsonMediaTypeFormatter formatter = config.Formatters.JsonFormatter;
            formatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

    }
}