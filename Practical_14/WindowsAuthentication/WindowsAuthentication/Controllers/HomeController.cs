using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowsAuthentication.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize(Users = @"SF-CPU-564\Demo")]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Users = @"SF-CPU-564\Demo")]
        public ActionResult About()
        {
            return View();
        }

        [Authorize(Users = @"SF-CPU-564\Demo")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}