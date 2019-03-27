using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.ValueObjects.Enums;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        protected Student() { }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
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

        public Student(string firstName,string lastName, string document,EnumDocumentType type, String email)
        {
            this.Name = new Name(firstName:firstName,lastName:lastName);
            this.Document = new Document(number:document, type: type);
            this.Email = new Email(address:email);
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