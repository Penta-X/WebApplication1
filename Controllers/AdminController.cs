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
        [Authorize]
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GetBlog(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("GetBlog", bl);
        }
        [Authorize]
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
        
        DataClasses1DataContext dc = new DataClasses1DataContext();
        [Authorize]
        public ActionResult Users()
        {
            var myUsers = dc.crudemp(null, null, null, null, null, 
                null, null, null, null, null, null, "Select").ToList();
            return View(myUsers);
        }

        public ActionResult Details(int id)
        {
            var empdetails = dc.crudemp(id, null, null, null, null, 
                null, null, null, null, null, null, "Details").Single(x => x.ID == id);
            return View(empdetails);
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult Create(User collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.crudemp(null, collection.name, collection.surname, 
                    collection.birthdate, collection.idnumber, 
                    collection.income, collection.phonenumber, 
                    collection.mail, collection.password, collection.gender, 
                    collection.familycode, "Insert");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Emp/Edit/5
        public ActionResult Edit(int id)
        {
            var empdetails = dc.crudemp(id, null, null, null, null,
                null, null, null, null, null, null, "Details").Single(x => x.ID == id);
            return View(empdetails);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                // TODO: Add update logic here
                dc.crudemp(id, collection.name, collection.surname,
                    collection.birthdate, collection.idnumber, collection.income,
                    collection.phonenumber, collection.mail, collection.password,
                    collection.gender, collection.familycode, "Update");
                dc.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            var empdetails = dc.crudemp(id, null, null, null, null, null, 
                null, null, null, null, null, "Details").Single(x => x.ID == id);
            return View(empdetails);
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                // TODO: Add delete logic here
                dc.crudemp(id, null, null, null, null, null, null, 
                    null, null, null, null, "Delete");
                dc.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}