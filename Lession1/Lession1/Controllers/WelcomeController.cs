using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lession1.Models;

namespace Lession1.Controllers
{
    public class WelcomeController : Controller
    {

        // GET: Welcome
        public ActionResult Index()
        {
            var user = new User();
            user.name = "Oanh Pham";
            user.address = "Hung Yen";
            user.email = "OanhPhmam99x@gmai.com";
            ViewBag.user = user;
            return View();

        }
   
    }
}