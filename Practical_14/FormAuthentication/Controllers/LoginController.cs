using FormAuthentication.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace FormAuthentication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Information model)
        {
            using (var context = new FormAuthenticationEntities())
            {
                bool isValid = context.login.Any(x => x.UserName == model.UserName && x.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false); ;
                    return RedirectToAction("Index", "Student_data");
                }

                ModelState.AddModelError("", "Invalid Username and Password");

                return View();
            }
        }

            public ActionResult Signup()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Signup(login model)
            {
                using (var context = new FormAuthenticationEntities())
                {
                    context.login.Add(model);
                    context.SaveChanges();
                }
                return RedirectToAction("login");
            }

             public ActionResult Logout()
             {
                FormsAuthentication.SignOut();
                return RedirectToAction("Login");

             }
        }
    }
