using System;
namespace StoreLibrary
{
    public class Location
    {
        /// <summary>
        /// This class is the main store class all store responsibilites should be handled in this
        /// class e.g ordering inventory etc
        /// </summary>
        ///
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        

        public Location(string name, List<Product> products)
        {

        }


    }
}
