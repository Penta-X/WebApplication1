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
        
        DataClasses1DataContext dc = new DataClasses1DataContext();
        [Authorize]
        public ActionResult Index()
        {
            var myBlogs = dc.crudblog(null, null, null, null, null, "Select").ToList();
            return View(myBlogs);
        }
        public ActionResult BlogDetails(int id)
        {
            var blogdetails = dc.crudblog(id, null, null, null, null, "Details")
                .Single(x => x.ID == id);
            return View(blogdetails);
        }
        public ActionResult BlogCreate()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult BlogCreate(Blog collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.crudblog(null, collection.title, collection.content,
                    collection.image, collection.date, "Insert");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult BlogEdit(int id)
        {
            var blogdetails = dc.crudblog(id, null, null, null, null, "Details")
                .Single(x => x.ID == id);
            return View(blogdetails);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult BlogEdit(int id, Blog collection)
        {
            try
            {
                // TODO: Add update logic here
                dc.crudblog(id, collection.title, collection.content,
                    collection.image, collection.date, "Update");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult BlogDelete(int id)
        {
            var blogdetails = dc.crudblog(id, null, null, null, null, "Details")
                .Single(x => x.ID == id);
            return View(blogdetails);
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult BlogDelete(int id, Blog collection)
        {
            try
            {
                // TODO: Add delete logic here
                dc.crudblog(id, null, null, null, null, "Delete");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
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