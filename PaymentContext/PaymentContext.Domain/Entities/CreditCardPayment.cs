using System;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        protected CreditCardPayment() { }
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
        public CreditCardPayment(string cardHolderName,
        string cardNumber, string lastTransactionNumber)
        {
            this.CardHolderName = cardHolderName;
            this.CardNumber = cardNumber;
            this.LastTransactionNumber = lastTransactionNumber;

            this.PaidDate = DateTime.Now;
            this.LastUpdate = DateTime.Now;
        }
    }

}
