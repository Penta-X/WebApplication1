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
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("GetBlog", bl);
        }
        public ActionResult BlogUpdate(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.content = b.content;
            blg.title = b.title;
            blg.image = b.image;
            blg.date = b.date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}