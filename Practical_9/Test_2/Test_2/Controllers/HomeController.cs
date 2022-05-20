using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //return view
        public ActionResult Index()
        {
            return View();
        }

        //return content
        public ContentResult about()
        {
            return Content("This is my Content");
        }

        //return HttpNotFound
        public HttpNotFoundResult error()
        {
            return HttpNotFound();
        }

        //return Empty result
        public EmptyResult empty()
        {
            return new EmptyResult();
        }

        //Return JavaScript result
        public JavaScriptResult JS()
        {
            return JavaScript("alert('This is JavaScript Result Example')");
        }
        
        //Return JSON result
        public JsonResult jsonex()
        {
            return Json(new { Name = "Vidhi", Status = "Trainee", Stack = "Asp.Net" }, JsonRequestBehavior.AllowGet);
        }



    }
}