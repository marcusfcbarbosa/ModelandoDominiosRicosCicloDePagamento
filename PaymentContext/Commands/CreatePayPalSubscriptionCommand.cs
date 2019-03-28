namespace PaymentContext.Domain.Commands
{
    public class CreatePayPalSubscriptionCommand
    {
        // Value Objects
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Document { get; set; }
        public String Email { get; set; }
        // Value Objects

        // Especifico do PayPal
        public string TranscationCode { get; set; }

        // Especifico do PayPal
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
        public String Number { get; set; }
        public String Neighborhood { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public String ZipCode { get; set; }
        // Propriedades do Address
        public string Owner { get; set; }
        public string PayerEmail { get; set; }

    }
}