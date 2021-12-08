using System.Web.Mvc;
using System.Linq;
using AnimalsStoreWeb.Models;

namespace AnimalsStoreWeb.Controllers
{
    public class OrderFormController : Controller
    {
        public ActionResult Index(int id)
        {
            AnimalStore database = new AnimalStore();
            shop_items item = database.shop_items.First(sItem => sItem.id == id);
            return View(item);
        }

        public ActionResult RegistrateOrder(orders order)
        {
            AnimalStore database = new AnimalStore();
            database.orders.Add(order);
            database.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}