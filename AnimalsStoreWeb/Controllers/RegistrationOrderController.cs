using AnimalsStoreWeb.Models;
using System.Web.Mvc;

namespace AnimalsStoreWeb.Controllers
{
    public class RegistrationOrderController : Controller
    {
        // GET: RegistrationOrder
        public ActionResult PreviewOrder(shop_items item)
        {

            return View(item);
        }
    }
}