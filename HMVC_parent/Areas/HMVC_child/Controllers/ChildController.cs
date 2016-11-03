using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMVC_child.Controllers
{
    public class ChildController : Controller
    {
        //
        // GET: /Child/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Child_page()
        {
            return View();
        }
      
	}
}