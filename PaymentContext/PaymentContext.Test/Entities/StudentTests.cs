using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.ValueObjects.Enums;
using Flunt.Validations;
using System;

namespace PaymentContext.Test.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void RetornaErrroQuandoAlunoJaPossuiInscricaoAtiva()
        {
            var name = new Name("Marcus Tste", "Correa Teste");
            var document = new Document("35848857873", EnumDocumentType.Cpf);
            var email = new Email("marcus@hotmail.com");
            var addres = new Address("Rua blablabla", "455", "vila santista", "Atibaia", "SP", "Brasi", "12955000");
            var student = new Student(name, document, email, addres);
            var subscription = new Subscription(true);
            var payment = new PayPalPayment("5F30CFBD-601B-4D26-89A4-1703D2E66C18", DateTime.Now,
            null, DateTime.Now.AddDays(30), 300, 300, addres, document,
            "owner", email);
            subscription.AddPayment(payment);
            student.AddSubscription(subscription);
            student.AddSubscription(subscription);
            Assert.IsTrue(student.Valid);
        }
    }
}