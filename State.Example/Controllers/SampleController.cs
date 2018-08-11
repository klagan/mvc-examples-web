using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewbagExample.Models;

namespace ViewbagExample.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MyCurrentDate = DateTime.Now.ToString();
            return View("Index");
        }

        [MyTestFilter]
        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }

        public ActionResult SamplePartial()
        {
            ViewBag.Data = DateTime.Now.ToString();
            return PartialView("_MyDateTime");
        }
    }
}