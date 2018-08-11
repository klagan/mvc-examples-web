using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCache.Example.Controllers
{
    public class SampleController : Controller
    {   
        public ActionResult NotCached()
        {
            ViewBag.MyDate = DateTime.Now.ToString();
            return View("NotCached");
        }

        //client cache is disabled - some how
        [OutputCache(Duration=10, Location=System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Cached()
        {
            ViewBag.MyDate = DateTime.Now.ToString();
            return View("Cached");
        }
    }
}