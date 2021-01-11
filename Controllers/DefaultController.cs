using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Classes;
using WebApplication1.Controllers;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        BlogIE blogs = new BlogIE();
        public ActionResult Index()
        {
            blogs.Value1 = c.Blogs.ToList();
            return View(blogs);
        }

        public ActionResult About()
        {
            return View();
        }


        public ActionResult SheltersMap()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var value = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(value);
        }
    }
}