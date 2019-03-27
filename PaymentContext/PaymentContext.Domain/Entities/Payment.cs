using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public Guid PaymentIdentifier { get; private set; }
        public DateTime PaidDate { get; private set; }

        public DateTime? LastUpdate { get; set; }
        public DateTime ExpireDate { get; private set; }
        public Decimal Total { get; private set; }
        public Decimal TotalPaid { get; private set; }
        public string Address { get; private set; }
        public string Document { get; private set; }
        public string Owner { get; private set; }
        public string Email { get; private set; }
    }
    public class BoletoPayment : Payment
    {
        protected BoletoPayment() { }
        public String Barcode { get; private set; }
        public Guid BoletoNumber { get; private set; }

        public BoletoPayment(String barcode,Guid boletoNumber = Guid.NewGuid()){
                this.Barcode = barcode;
                this.BoletoNumber = boletoNumber;
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