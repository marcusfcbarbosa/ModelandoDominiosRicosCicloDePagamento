using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositorys
{
    public interface IStudentRepository
    {
        bool DocumentExists(string document);

        bool EmailExists(string email);

        void CreateSubscription(Student student);

    }
}