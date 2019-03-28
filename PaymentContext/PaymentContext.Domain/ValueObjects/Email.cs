using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Shared.ValueObjects;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new Contract()
            .Requires()
            .IsEmail(Address, "Email.Address", "E-mail inválido")
            );
        }
        public String Address { get; private set; }
    }
}