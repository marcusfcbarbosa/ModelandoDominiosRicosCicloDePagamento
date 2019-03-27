using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Test.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student(firstName: "Marcos", 
            lastName: "Correa", 
            document: "78989898798", 
            email: "sdfdfsfsfd@hotmail.com");
        }
    }
}