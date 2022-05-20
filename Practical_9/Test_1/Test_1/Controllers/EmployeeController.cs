using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string Index(string Name)
        {
            return "Hello " + Name;
        }
    }
}