using System;
using Flunt.Notifications;
using PaymentContext.Domain.ValueObjects.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreateCreditCardSubscriptionComand : Notifiable, ICommand
    {
        // Value Objects
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Document { get; set; }
        public String Email { get; set; }
        // Value Objects

        //Especifico do CrediCard
        public string CardHolderName { get;  set; }
        public string CardNumber { get;  set; }
        public string LastTransactionNumber { get;  set; }
        //Especifico do CrediCard

        public String Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public Decimal ExpireDate { get; set; }
        public Decimal Total { get; set; }
        public Decimal TotalPaid { get; set; }

        public String PayerDocument { get; set; }
        public EnumDocumentType PayerDocumentType
        {
            get
            {
                return EnumDocumentType.Cpf;
            }
        }

        // Propriedades do Address
        public String Street { get; set; }
        public String PayerAddressNumber { get; set; }
        public String Neighborhood { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public String ZipCode { get; set; }
        // Propriedades do Address
        public string Owner { get; set; }
        public string PayerEmail { get; set; }
        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}