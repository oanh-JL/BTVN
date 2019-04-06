using Lession1.Models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession1.Controllers
{
    public class ProductController : Controller
    {
        DBContext db = new DBContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.Products);
        }
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "NameVN");
            return View();
        }
        public ActionResult Edit(int? id)
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "NameVN");
            return View(db.Products.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Redirect("Index");
        }
     
        public ActionResult Delete(int id)
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "NameVN");
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return Redirect("Index");
        }
    }
}