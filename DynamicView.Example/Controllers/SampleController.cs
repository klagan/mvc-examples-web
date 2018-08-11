using DynamicView.Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicView.Example.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            var vm = new StudentTeacherViewModel();
            vm.Students = GetStudents();
            vm.Teachers = GetTeachers();

            return View(vm);
        }

        public IList<Student> GetStudents()
        {
            var s = new List<Student> {
                new Student { Id = 1, Name = "Kam Lagan", Subject = "MVC" },
                new Student { Id = 2, Name = "Darren Lagan", Subject = "Azure" }
            };

            return s;
        }

        public IList<Teacher> GetTeachers()
        {
            var t = new List<Teacher> {
                new Teacher { Id = 1, Name = "Badri Prasad", Subject = "MVC" },
                new Teacher { Id = 2, Name = "Harshit Gupta", Subject = "Azure" }
            };

            return t;
        }
    }
}