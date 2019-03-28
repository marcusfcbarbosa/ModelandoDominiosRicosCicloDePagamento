using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using Flunt.Validations;


namespace PaymentContext.Test.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Marcus", "Fernando");
            foreach(var not in name.Notifications){
                //not.Message;
            }
        }
    }
}