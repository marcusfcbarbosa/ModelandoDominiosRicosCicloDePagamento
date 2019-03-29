using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.ValueObjects.Enums;
using Flunt.Validations;
using System;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Handlers;
using PaymentContext.Test.Mocks;

namespace PaymentContext.Test.Handlers
{

    [TestClass]
    public class SubscriptionHandlerTest
    {
        public SubscriptionHandlerTest()
        {
        }

        [TestMethod]
        public void RetornaErrroQuandoAlunoJaPossuiInscricaoAtiva()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";
            command.LastName = "";
            command.Document = "";
            command.Email = "";
            command.Barcode = "";
            command.BoletoNumber = Guid.NewGuid();
            command.Number = "12";
            command.PaidDate = DateTime.Now;
            command.LastUpdate = DateTime.Now;
            command.ExpireDate = DateTime.Now;
            command.Total = 0;
            command.TotalPaid = 0;
            command.Street = "";
            command.PayerAddressNumber = "";
            command.Neighborhood = "";
            command.City = "";
            command.State = "";
            command.Country = "";
            command.ZipCode = "";
            command.Owner = "";
            command.PayerEmail = "";
            command.PayerDocument = "";
            
            handler.Handle(command);

            Assert.AreEqual(false,handler.Valid);
        }
    }
}