using System.ComponentModel.DataAnnotations;

namespace Ef_Intro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Dont do this")]
        public int Age { get; set; }
    }
}