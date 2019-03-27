using System;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        protected BoletoPayment() { }
        public String Barcode { get; private set; }
        public Guid BoletoNumber { get; private set; }

        public BoletoPayment(String barcode, Guid boletoNumber)
        {
            this.Barcode = barcode;
            this.BoletoNumber = boletoNumber;

            this.PaidDate = DateTime.Now;
            this.LastUpdate = DateTime.Now;
        }

    }
}
