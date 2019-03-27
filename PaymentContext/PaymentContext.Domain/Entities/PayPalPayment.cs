using System;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {

        public string LastTranscationCode { get; private set; }
        public PayPalPayment(string lastTranscationCode,

            DateTime paidDate, DateTime? lastUpdate,
            DateTime expireDate, decimal total, decimal totalPaid,
            Address address, string document, string owner, string email)

        : base(paidDate, lastUpdate, expireDate,
         total, totalPaid, address,
         document, owner, email)
        {
            this.LastTranscationCode = lastTranscationCode;
        }
    }
}