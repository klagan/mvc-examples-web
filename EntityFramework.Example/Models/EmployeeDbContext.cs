using System.Data.Entity;

namespace Ef_Intro.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() 
            : base("EmployeeConn"){}

        public DbSet<Employee> Employees { get; set; }
    }
}