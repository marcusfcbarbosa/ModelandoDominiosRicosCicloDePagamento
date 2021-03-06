using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity
    {
        protected Subscription() { }
        public bool Active { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LasUpdateDate { get; private set; }
        public DateTime? ExpirationDate { get; private set; }
        private IList<Payment> _payments;
        public IReadOnlyCollection<Payment> Payments
        {
            get
            {
                return this._payments.ToArray();
            }
        }
        public Payment AddPayment(Payment payment)
        {
            AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription._payments", "A data de pagamento deve ser futura"));

            if (Valid)
                this._payments.Add(payment);

            return payment;
        }
        public Subscription(bool active = true)
        {
            this.Active = active;
            this.CreateDate = DateTime.Now;
            this._payments = new List<Payment>();
        }
        public void DisableSubscription()
        {
            this.Active = false;
            this.LasUpdateDate = DateTime.Now;
        }
        public void SetExpirationDate(DateTime date)
        {
            this.ExpirationDate = date;
            this.LasUpdateDate = DateTime.Now;
        }
    }
}