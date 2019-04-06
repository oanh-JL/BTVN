using Lession1.Models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession1.Controllers
{
    public class LayoutController : Controller
    {
        DBContext db = new DBContext();
        // GET: Layout
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadNav()
        {

            return PartialView(db.Menus);
        }
        public ActionResult IndexWithLayout()
        {
            return View(db.Products.OrderByDescending(
                p=>p.UnitPrice).Take(2));
        }
        public ActionResult CategoryLayout()
        {
            return View(db.Categories);
        }
        public ActionResult ShowProduct(int id)
        {
            return View(db.Categories.Find(id).Products);
        }
        
    }
}