using System;
using System.Collections;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        protected Subscription() { }
        public bool Active { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LasUpdateDate { get; private set; }
        public DateTime? ExpirationDate { get; private set; }
        public IEnumerable <Payment> Payments {get;set;}
        public Subscription(bool active = true)
        {
            this.Active = active;
            this.CreateDate = DateTime.Now;
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