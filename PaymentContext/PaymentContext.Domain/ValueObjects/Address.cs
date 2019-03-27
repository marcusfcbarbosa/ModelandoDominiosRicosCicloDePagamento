using System;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{

    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public String Street { get; private set; }
        public String Number { get; private set; }
        public String Neighborhood { get; private set; }
        public String City { get; private set; }
        public String State { get; private set; }
        public String Country { get; private set; }
        public String ZipCode { get; private set; }
    }

}