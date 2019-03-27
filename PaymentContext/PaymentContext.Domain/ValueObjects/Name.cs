using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{

    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public String FirstName { get; private set; }
        public String LastName { get; private set; }
    }


}