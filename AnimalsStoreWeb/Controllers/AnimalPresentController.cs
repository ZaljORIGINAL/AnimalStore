using AnimalsStoreWeb.Models;
using System.Linq;
using System.Web.Mvc;

namespace AnimalsStoreWeb.Controllers
{
    public class AnimalPresentController : Controller
    {
        // GET: AnimalPresent
        public ActionResult GetAnimal(int id)
        {
            StoreDatabase storeDatabase = new StoreDatabase();
            shop_items shopItem = storeDatabase.shop_items.First(item => item.id == id);
            return View(shopItem);
        }

        public ActionResult RegistrateOrder(shop_items item)
        {
            return RedirectToAction("PreviewOrder", "RegistrationOrder", item);
        }
    }
}