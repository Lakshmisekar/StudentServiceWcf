using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentService
{
    public class StudentContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Student> Students { get; set; }
    }
}