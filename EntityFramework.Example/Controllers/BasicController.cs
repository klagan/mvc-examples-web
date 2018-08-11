using Ef_Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ef_Intro.Controllers
{
    public class BasicController : Controller
    {
        EmployeeDbContext dbContext = new EmployeeDbContext();
      
        public ActionResult Index()
        {            
            return View(dbContext.Employees.ToList());
        }

        public ActionResult Details(int id = 0)
        {
            Employee employee = dbContext.Employees.Find(id);

            if (employee != null)
            {
                return View(employee);
            }

            return HttpNotFound();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }
    }
}