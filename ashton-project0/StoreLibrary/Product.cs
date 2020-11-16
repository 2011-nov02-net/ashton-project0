using System;
namespace StoreLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        // TODO: Stock should be part of inventory class/Interface
        public int Stock { get; set; }


        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }


    }
}
