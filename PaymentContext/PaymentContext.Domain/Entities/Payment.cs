using System;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public Guid PaymentIdentifier { get;  set; }
        public DateTime PaidDate { get;  set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime ExpireDate { get;  set; }
        public Decimal Total { get;  set; }
        public Decimal TotalPaid { get;  set; }
        public string Address { get;  set; }
        public string Document { get;  set; }
        public string Owner { get;  set; }
        public string Email { get;  set; }
    }
    public class BoletoPayment : Payment
    {
        protected BoletoPayment() { }
        public String Barcode { get; private set; }
        public Guid BoletoNumber { get; private set; }

        public BoletoPayment(String barcode,Guid boletoNumber){
                this.Barcode = barcode;
                this.BoletoNumber = boletoNumber;

                this.PaidDate = DateTime.Now;
                this.LastUpdate = DateTime.Now;
        }

    }
    public class CreditCardPayment : Payment
    {
        protected CreditCardPayment() { }
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
        public CreditCardPayment(string cardHolderName,
        string cardNumber,string lastTransactionNumber){
                this.CardHolderName = cardHolderName;
                this.CardNumber = cardNumber;
                this.LastTransactionNumber = lastTransactionNumber;

                this.PaidDate = DateTime.Now;
                this.LastUpdate = DateTime.Now;
        }
    }
    public class PayPalPayment : Payment
    {
        protected PayPalPayment() { }
        public string LastTranscationCode { get; private set; }

        public PayPalPayment(string lastTranscationCode){
                this.LastTranscationCode = lastTranscationCode;
                this.PaidDate = DateTime.Now;
                this.LastUpdate = DateTime.Now;
        }

    }
}