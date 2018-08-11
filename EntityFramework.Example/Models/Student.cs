using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ef_Intro.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [CustomAgeValidation(ErrorMessage ="Age is out of range")]
        public int Age { get; set; }
    }

    public class CustomAgeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var age = Convert.ToInt32(value);
            
            return ((age >= 21) && (age <= 60));
        }
    }
}