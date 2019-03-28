using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Shared.ValueObjects;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName,string lastName)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(FirstName, "Name.FirstName", "Nome não esta preenchido")
            );

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(LastName, "Name.LastName", "Sobrenome não esta preenchido")
            );

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(firstName, 2, "Name.FirstName", "Tamanho de primeiro nome excede tamanho permitido"));

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(LastName, 2, "Name.LastName", "Tamanho de sobrenome excede tamanho permitido"));

            FirstName = firstName;
            LastName = lastName;
        }
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
    }
}