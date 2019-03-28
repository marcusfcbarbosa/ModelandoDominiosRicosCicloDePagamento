using System;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public string TranscationCode { get; private set; }
        public PayPalPayment(string transcationCode,

            DateTime paidDate, DateTime? lastUpdate,
            DateTime expireDate, decimal total, decimal totalPaid,
            Address address, Document document, string owner, Email email)
        : base(paidDate, lastUpdate, expireDate,
         total, totalPaid, address,
         document, owner, email)
        {
            this.TranscationCode = transcationCode;
        }
    }
}