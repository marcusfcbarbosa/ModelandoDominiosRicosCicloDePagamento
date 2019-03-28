using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects.Enums;

namespace PaymentContext.Test.ValueObjects{

    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void AdicionarAssinaturaDeveRetornarErroComCnpjInvalido()
        {
            var doc = new Document("1223354654", type: EnumDocumentType.Cnpj);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void AdicionarAssinaturaDeveRetornarSucessoComCnpjValido()
        {
            var doc = new Document("86793348000107", type: EnumDocumentType.Cnpj);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void AdicionarAssinaturaDeveRetornarErroComCpfInvalido()
        {
            var doc = new Document("1223354654", type: EnumDocumentType.Cpf);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void AdicionarAssinaturaDeveRetornarErroComCpfValido()
        {
            var doc = new Document("35848857873", type: EnumDocumentType.Cpf);
            Assert.IsTrue(doc.Valid);
        }
    }
}