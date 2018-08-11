using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax.Example.Models;

namespace Ajax.Example.Controllers
{
    public class SampleController : Controller
    {
        StudentDbEntities dbContext = new StudentDbEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetA()
        {
            var result = dbContext.Students.Where(x => x.FirstName == "a");
            return PartialView("_FirstName", result);
        }

        public ActionResult GetB()
        {
            var result = dbContext.Students.Where(x => x.FirstName == "b");
            return PartialView("_FirstName", result);
        }
    }
}