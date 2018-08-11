using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exception.Example.Controllers
{
    public class SampleController : Controller
    {
        //remember IE can be funny about the page size and return a 503 instead of the custom error page
        [HandleError(ExceptionType = typeof(System.Exception), View ="_MyError")]
        public ActionResult Index()
        {
            throw new System.Exception("Custom Exception");
            return View();
        }
    }
}