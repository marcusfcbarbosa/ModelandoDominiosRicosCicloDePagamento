using System;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
        public CreditCardPayment(string cardHolderName,string cardNumber, string lastTransactionNumber,

            DateTime paidDate, DateTime? lastUpdate,
            DateTime expireDate, decimal total, decimal totalPaid,
            Address address, Document document, string owner, string email)
        :base(paidDate, lastUpdate,  expireDate, 
         total,  totalPaid,  address, 
         document,  owner, email)
        {
            this.CardHolderName = cardHolderName;
            this.CardNumber = cardNumber;
            this.LastTransactionNumber = lastTransactionNumber;
        }
    }
}