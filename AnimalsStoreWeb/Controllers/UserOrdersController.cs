using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AnimalsStoreWeb.Models;

namespace AnimalsStoreWeb.Controllers
{
    public class UserOrdersController : Controller
    {
        public ActionResult Index(string email)
        {
            List<orders> ordersList = new List<orders>();
            if (email.Length != 0)
            {
                AnimalStore database = new AnimalStore();
                ordersList = database.orders.Where(order => order.email.Equals(email)).ToList();
            }

            return View(new FindedOrders(email, ordersList));
        }
    }
}