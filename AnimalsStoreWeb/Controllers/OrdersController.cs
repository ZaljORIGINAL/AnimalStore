using System.Web.Mvc;

namespace AnimalsStoreWeb.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}