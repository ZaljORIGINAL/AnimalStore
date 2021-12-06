using System.Collections.Generic;

namespace AnimalsStoreWeb.Models
{
    public class FindedOrders
    {
        public string Email;

        public List<orders> OrdersList;

        public FindedOrders(string email, List<orders> ordersList)
        {
            Email = email;
            OrdersList = ordersList;
        }
    }
}