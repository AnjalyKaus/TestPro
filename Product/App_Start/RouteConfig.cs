using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Product
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Product.Controllers"}
            );
        }
    }
}

namespace Product.Areas.Marketing
{
    public class MarketingAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Marketing";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Marketing_default",
                "Marketing/{controller}/{action}/{id}",
                new { controller= "Marketing", action = "Index", id = UrlParameter.Optional },
                new string[] { "Marketing.Controllers"}
            );
        }
    }
}

namespace Product.Areas.test
{
    public class testAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "test";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "test_default",
                "test/{controller}/{action}/{id}",
                new { controller = "check", action = "Index", id = UrlParameter.Optional },
                new string[] { "test.Controllers"}
            );
        }
    }
}   
