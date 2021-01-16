using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models.Classes;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var info = c.Admins.FirstOrDefault(x => x.mail == ad.mail && x.password == ad.password);
            var info2 = c.Users.FirstOrDefault(x => x.mail == ad.mail && x.password == ad.password);

            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.mail, false);
                Session["mail"] = info.mail.ToString();
                return RedirectToAction("Index", "Admin");
            }
            
            else if (info2 != null)
            {
                FormsAuthentication.SetAuthCookie(info2.mail, false);
                Session["mail2"] = info2.mail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}