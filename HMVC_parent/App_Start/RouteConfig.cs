using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HMVC_parent
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                 "{controller}/{action}/{id}",
                new { controller = "Parent", action = "Parent_page", id = UrlParameter.Optional },
                new string[] { "HMVC_parent.Contollers" }
            );
        }
    }
}
namespace HMVC_parent.Areas.HMVC_child
{
    public class HMVC_childAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "HMVC_child";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "HMVC_child_default",
                "HMVC_child/{controller}/{action}/{id}",
                new { controller = "Child", action = "Index", id = UrlParameter.Optional },
                new string[] { "HMVC_child.Contollers" }
            );
        }
    }
}