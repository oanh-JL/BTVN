using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //
        public ActionResult Index(Lession1.Models.User user)
        {
            //if (user.name == "oanh")
            //{
            //    String msg = "Welcome " + user.name;

            //    return Content(msg);
            //}
            //else
            //{
            //    ViewBag.User = user;
            //    return View("/Views/Welcome/index.cshtml");
            //}

            return View();
        }

    }
}