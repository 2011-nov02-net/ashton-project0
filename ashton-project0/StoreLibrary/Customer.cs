using System;
namespace StoreLibrary
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }


        public Customer(string firstName, string lastName, string streetAddress, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = streetAddress;
            PhoneNumber = phoneNumber;
        }


    }
}
