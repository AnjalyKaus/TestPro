using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMVC_parent.Controllers
{
    public class ParentController : Controller
    {
        //
        // GET: /Parent/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Parent_page()
        {
            return View();
        }
	}
}