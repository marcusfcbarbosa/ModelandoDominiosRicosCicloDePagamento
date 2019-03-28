using System;
using PaymentContext.Domain.ValueObjects.Enums;
using PaymentContext.Shared.Commands;
using Flunt.Validations;
using Flunt.Notifications;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {
        public CreateBoletoSubscriptionCommand() { }
        // Value Objects
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Document { get; set; }
        public String Email { get; set; }
        // Value Objects

        //Especifico do Boleto
        public String Barcode { get; set; }
        public Guid BoletoNumber { get; set; }
        //Especifico do Boleto

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
            //Fail Fast Validation, funciona para as validações que estão no Command
            //Desafoga utilização de BD , para validaçoes primarias
            AddNotifications(new Contract()
            .Requires()
                .IsNullOrEmpty(FirstName, "Name.FirstName", "Nome não esta preenchido")
                .HasMinLen(FirstName, 2, "Name.FirstName", "Tamanho de primeiro nome precisa de no minimo 2 digitos")
                .IsNullOrEmpty(LastName, "Name.LastName", "Sobrenome não esta preenchido")
                .HasMinLen(LastName, 2, "Name.LastName", "Tamanho de sobrenome precisa de no minimo 2 digitos")
            );
        }
    }
}