using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimalsStoreWeb.Controllers
{
    public class AnimalStoreController : Controller
    {
        // GET: AnimalStore
        public ActionResult Index()
        {
            return View();
        }
    }
}