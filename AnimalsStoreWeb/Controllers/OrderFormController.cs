using System.Web.Mvc;
using System.Linq;
using AnimalsStoreWeb.Models;

namespace AnimalsStoreWeb.Controllers
{
    public class OrderFormController : Controller
    {
        public ActionResult Index(int id)
        {
            StoreDatabase database = new StoreDatabase();
            shop_items item = database.shop_items.First(sItem => sItem.id == id);
            return View(item);
        }

        public ActionResult RegistrateOrder(orders order)
        {
            StoreDatabase database = new StoreDatabase();
            database.orders.Add(order);
            database.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}