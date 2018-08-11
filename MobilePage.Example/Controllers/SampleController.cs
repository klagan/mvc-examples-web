using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilePage.Example.Controllers
{
    public class SampleController : Controller
    {        
        public ActionResult Index()
        {
            if (Request.Browser.IsMobileDevice)
                return View("Index.mobile");

            return View("Index");
        }
    }
}