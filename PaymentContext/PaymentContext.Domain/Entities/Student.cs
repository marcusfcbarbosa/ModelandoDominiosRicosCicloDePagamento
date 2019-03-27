using System;
using System.Collections;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        protected Student() { }
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Document { get; private set; }
        public String Email { get; private set; }
        public DateTime CreationDate {get; private set;}
        public bool Status {get;private set;}
        public DateTime? UpdateDate {get; private set;}
        public IEnumerable<Subscription> Subscriptions  { get; set; }
        public string Address { get; private set; }
        public Student(String firstName,String lastName,String document, String email)
        {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Document = document;
                this.Email = email;
                this.CreationDate = DateTime.Now;
                this.Status = true;
        }
        public void DeleteStudent(){
            this.Status = false;
            this.UpdateDate = DateTime.Now;
        }
    }

}