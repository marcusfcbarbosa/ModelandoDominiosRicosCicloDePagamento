using System;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment( DateTime paidDate, DateTime? lastUpdate, DateTime expireDate, 
        decimal total, decimal totalPaid, string address, 
        string document, string owner, string email)
        {
            PaymentIdentifier = Guid.NewGuid();
            PaidDate = paidDate;
            LastUpdate = lastUpdate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Address = address;
            Document = document;
            Owner = owner;
            Email = email;
        }
        public Guid PaymentIdentifier { get; private  set; }
        public DateTime PaidDate { get;  private set; }
        public DateTime? LastUpdate { get; private set; }
        public DateTime ExpireDate { get;  private set; }
        public Decimal Total { get;  private set; }
        public Decimal TotalPaid { get; private set; }
        public string Address { get; private set; }
        public string Document { get; private set; }
        public string Owner { get; private set; }
        public string Email { get; private set; }
    }
}