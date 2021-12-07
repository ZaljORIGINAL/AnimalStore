using System.Collections.Generic;

namespace AnimalsStoreWeb.Models
{
    public class FindedOrders
    {
        public string email;

        public List<orders> OrdersList;

        public FindedOrders(string email, List<orders> ordersList)
        {
            this.email = email;
            OrdersList = ordersList;
        }
    }
}