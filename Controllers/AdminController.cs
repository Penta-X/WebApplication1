using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Classes;
namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
    }
}