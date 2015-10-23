using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace toy_app.Controllers
{
    public class StaticPagesController : Controller
    {
        //Home
        //Help
        //About
        public ActionResult Home()
        {
            return View();
        }
	}
}