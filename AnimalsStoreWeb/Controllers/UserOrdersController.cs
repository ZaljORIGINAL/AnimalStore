using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AnimalsStoreWeb.Models;

namespace AnimalsStoreWeb.Controllers
{
    public class UserOrdersController : Controller
    {
        // GET
        /*public ActionResult Index(string email)
        {
            List<orders> ordersList = new List<orders>();
            if (email.Length != 0)
            {
                StoreDatabase database = new StoreDatabase();
                ordersList = database.orders.Where(orders => orders.Equals(email)).ToList();
            }
            
            return View(new FindedOrders(email, ordersList));
        }*/
        public ActionResult Index()
        {
            return View();
        }
    }
}