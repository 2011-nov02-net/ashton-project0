using System;
namespace StoreLibrary
{
    public class Knives : Product
    {
        public Knives()
        {
        }

        public Knives(string name, double price, int stock) : base(name, price, stock)
        {
        }
    }
}
