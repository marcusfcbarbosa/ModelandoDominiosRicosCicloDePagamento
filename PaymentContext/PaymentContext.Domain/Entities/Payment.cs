using System;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate, DateTime? lastUpdate,
        DateTime expireDate, decimal total, decimal totalPaid,
         Address address, Document document, string owner, string email)
        {
            PaymentIdentifier = Guid.NewGuid();
            PaidDate = paidDate;
            LastUpdate = lastUpdate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Address = new Address(
                 street: address.Street, number: address.Number,
                 neighborhood: address.Neighborhood, city: address.City,
                 state: address.State, country: address.Country, zipCode: address.ZipCode);

            Document = new Document(document.Number, document.Type);
            Owner = owner;
            Email = email;

            AddNotifications(new Contract()
                    .Requires()
                    .IsGreaterThan(0, Total, "Payment.Total", "Pagamento total não pode ser ZERO")
                    .IsGreaterOrEqualsThan(Total, TotalPaid, "Payment.TotalPaid", "O valor pago é menor que o valor do pagamento")
            );
        }
        public Guid PaymentIdentifier { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime? LastUpdate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public Decimal Total { get; private set; }
        public Decimal TotalPaid { get; private set; }
        public Address Address { get; private set; }
        public Document Document { get; private set; }
        public string Owner { get; private set; }
        public string Email { get; private set; }
    }
}