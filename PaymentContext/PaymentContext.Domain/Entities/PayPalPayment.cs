using System;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        protected PayPalPayment() { }
        public string LastTranscationCode { get; private set; }
        public PayPalPayment(string lastTranscationCode)
        {
            this.LastTranscationCode = lastTranscationCode;
            this.PaidDate = DateTime.Now;
            this.LastUpdate = DateTime.Now;
        }
    }
}