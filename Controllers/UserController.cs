using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Classes;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        // GET: User
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Ticket collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.sendTicket(null, collection.text, collection.date,
                    collection.userid, "Insert");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Donate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Donate(Donation collection)
        {

            try
            {
                // TODO: Add insert logic here
                dc.crudDonate(null, collection.userid, collection.amount,
                    false, collection.date, "Insert");
                dc.SubmitChanges();
                return RedirectToAction("Donate");
            }
            catch
            {
                return View();
            }
        }
    }
}