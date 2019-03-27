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
        public Student(
                Name name,
                Document document,
                Email email,
                DateTime creationDate,
                bool status,
                Address address)
        {
            Name = name;
            Document = new Document(document.Number,document.Type);
            Email = email;
            CreationDate = creationDate;
            Status = status;
            Address = new Address(
                 street:address.Street, number:address.Number,
                 neighborhood:address.Neighborhood, city:address.City,
                 state:address.State, country:address.Country, zipCode:address.ZipCode);
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public DateTime CreationDate { get; private set; }
        public bool Status { get; private set; }
        public Address Address { get; private set; }
        public DateTime? UpdateDate { get; private set; }
        private IList<Subscription> _subscriptions;
        public IReadOnlyCollection<Subscription> Subscriptions
        {
            get
            {
                return this._subscriptions.ToArray();
            }
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