using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email: ValueObject
    {
        public Email(string address)
        {
            //faz lguma validação aqui
            Address = address;
        }
        public String Address { get; private set; }
    }
}