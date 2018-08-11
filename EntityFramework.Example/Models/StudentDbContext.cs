using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ef_Intro.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() 
            : base("StudentDbConn") { }

        public System.Data.Entity.DbSet<Ef_Intro.Models.Student> Students { get; set; }
    }
}