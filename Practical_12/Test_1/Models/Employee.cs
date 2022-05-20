using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Test_1.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "DOB is Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }

    }

    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}