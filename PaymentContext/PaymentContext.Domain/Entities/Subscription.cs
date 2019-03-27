
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
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