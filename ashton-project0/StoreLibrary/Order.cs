using System;
using System.Collections.Generic;
namespace StoreLibrary
{
    public class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Location Location { get; set; }
        public DateTime OrderTime { get; set; }
        public Customer Customer { get; set; }
        
        public Order(Location location, List<Product> products, DateTime orderTime, Customer customer)
        {
            Location = location;
            OrderTime = orderTime;
            Customer = customer;

        }
    }
}
