using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetsStore.Models;
namespace PetsStore.Controllers
{
    public class PetsController : Controller
    {
        // GET: Pets
        public ActionResult Index()
        {
            

            return View(Pets.getPets());
        }

        public ActionResult Create()
        {
            Pet pet = new Pet();
            return View(pet);
        } 
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}