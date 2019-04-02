using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lession1.Models;

namespace Lession1.Controllers
{
    public class ModelDemoController : Controller
    {
     
        // GET: bai3
        public ActionResult Index()
        {
            var users = new List<User>();
            var user1 = new User(1, "Oanh", "HY", "OanhPham");
            var user2 = new User(2, "Trang", "HY", "OanhPham");
            users.Add(user1);
            users.Add(user2);
            return View(users);
        }
    }
}