using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicView.Example.Models
{
    public class StudentTeacherViewModel
    {
        public IList<Student> Students { get; set; }
        public IList<Teacher> Teachers { get; set; }
    }
}