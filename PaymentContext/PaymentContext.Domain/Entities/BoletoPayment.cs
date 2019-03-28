using System;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public String Barcode { get; private set; }
        public Guid BoletoNumber { get; private set; }
        public BoletoPayment(String barcode, Guid boletoNumber,

                    DateTime paidDate, DateTime? lastUpdate,
                    DateTime expireDate, decimal total, decimal totalPaid,
                    Address address, Document document, string owner, Email email)
                    : base(paidDate, lastUpdate, expireDate,
             total, totalPaid, address,
            document, owner, email)

        {
            
            this.Barcode = barcode;
            this.BoletoNumber = boletoNumber;
        }
    }
}