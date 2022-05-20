using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test_2.Models
{
    public class EmpContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }

    }
}