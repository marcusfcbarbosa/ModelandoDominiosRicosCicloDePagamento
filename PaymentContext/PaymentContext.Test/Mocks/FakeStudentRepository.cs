using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositorys;

namespace PaymentContext.Test.Mocks
{

    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
            throw new System.NotImplementedException();
        }

        public bool DocumentExists(string document)
        {
            throw new System.NotImplementedException();
        }

        public bool EmailExists(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}