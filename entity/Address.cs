using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.entity
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string country, string city, string street, int houseNumber, string zipCode)
        {
            Country = country;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
        }

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string ZipCode { get; set; }
    }

}
