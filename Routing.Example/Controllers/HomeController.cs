using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MyController = RouteData.Values["Controller"];
            ViewBag.MyAction = RouteData.Values["Action"];
            return View();
        }
    }
}