using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        // default constructor
        public Contact()
        {

        }
        // constructor with parameter
        public Contact(string firstName, string lastName, string address, string city, string zipCode, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }
    }
}
