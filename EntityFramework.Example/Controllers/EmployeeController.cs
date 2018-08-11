using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ef_Intro.Models;

namespace Ef_Intro.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var dbContext = new EmployeeDbContext();

            return View(dbContext.Employees.ToList());
        }
    }
}