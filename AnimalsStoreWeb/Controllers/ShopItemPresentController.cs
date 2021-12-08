using System.Linq;
using System.Web.Mvc;
using AnimalsStoreWeb.Models;

namespace AnimalsStoreWeb.Controllers
{
    public class ShopItemPresentController : Controller
    {
        // GET
        public ActionResult Index(int id)
        {
            AnimalStore database = new AnimalStore();
            shop_items item = database.shop_items.First(sItem => sItem.id == id);
            return View(item);
        }

        public ActionResult Buy(int itemId)
        {
            return RedirectToAction("Index", "OrderForm", itemId);
        }
    }
}