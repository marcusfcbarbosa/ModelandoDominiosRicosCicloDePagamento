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
            if(string.IsNullOrEmpty(firstName)){
                AddNotification("Name.FirstName","Nome inválido");
            }

            if(string.IsNullOrEmpty(lastName)){
                AddNotification("Name.LastName","Sobrenome inválido");
            }

            FirstName = firstName;
            LastName = lastName;
        }

        public String FirstName { get; private set; }
        public String LastName { get; private set; }
    }


}