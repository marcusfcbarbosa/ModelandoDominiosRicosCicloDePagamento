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
        public Name(string firstName,
                    string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(FirstName, "Name.FirstName", "Nome não esta preenchido")
            );

            AddNotifications(new Contract()
                .Requires()
                .IsNullOrEmpty(FirstName, "Name.LastName", "Sobrenome não esta preenchido")
            );

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(firstName, 200, "Name.FirstName", "Tamanho de primeiro nome excede tamanho permitido"));

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(LastName, 200, "Name.LastName", "Tamanho de sobrenome excede tamanho permitido"));

        }
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
    }
}