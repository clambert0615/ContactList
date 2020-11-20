using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public Contact() { }
        public Contact(string firstName, string lastName, string phoneNumber, string email, string streetAddress, string city, string state, int zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
    
}
