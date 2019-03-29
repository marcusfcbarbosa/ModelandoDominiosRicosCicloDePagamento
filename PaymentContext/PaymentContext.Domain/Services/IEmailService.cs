using System;
using PaymentContext.Shared.ValueObjects;


namespace PaymentContext.Domain.Services
{
    public interface IEmailService{
        void Send(string to, string email, string body);
    }
}