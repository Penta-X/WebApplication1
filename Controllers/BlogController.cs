using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Classes;
using WebApplication1.Controllers;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogIE blogs = new BlogIE();
        public ActionResult Index()
        {
            //var blogs = c.Blogs.ToList();
            blogs.Value1 = c.Blogs.ToList();
            blogs.Value2 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blogs);
        }

        public ActionResult BlogDetail(int id)
        {
            //var findBlog = c.Blogs.Where(x => x.ID == id).ToList();
            blogs.Value1 = c.Blogs.Where(x => x.ID == id).ToList();
            blogs.Value2 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blogs);
        }
    }
}