using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        protected Student(){}
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Document { get; private set; }
        public String Email { get; private set; }
        public DateTime CreationDate { get; private set; }
        public bool Status { get; private set; }
        public DateTime? UpdateDate { get; private set; }
        private IList<Subscription> _subscriptions;
        public IReadOnlyCollection<Subscription> Subscriptions
        {
            get
            {
                return this._subscriptions.ToArray();
            }
        }
        public string Address { get; private set; }
        public Student(String firstName, String lastName, String document, String email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Document = document;
            this.Email = email;
            this.CreationDate = DateTime.Now;
            this.Status = true;
            this._subscriptions = new List<Subscription>();
        }
        public void AddSubscription(Subscription subscription)
        {
            this.Subscriptions.ToList().ForEach(item =>
                {
                    item.DisableSubscription();
                });
            this._subscriptions.Add(subscription);
        }
        public void DeleteStudent()
        {
            this.Status = false;
            this.UpdateDate = DateTime.Now;
        }
    }
}