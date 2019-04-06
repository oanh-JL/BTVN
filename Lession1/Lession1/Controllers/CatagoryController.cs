using Lession1.Models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession1.Controllers
{
    public class CatagoryController : Controller
    {
        DBContext db = new DBContext();
        // GET: Catagory
        public ActionResult Index()
        {
            return View(db.Categories);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            db.Categories.Add(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}