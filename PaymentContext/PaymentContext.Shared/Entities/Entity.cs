using System;
using System.Collections;
using System.Collections.Generic;
using Flunt.Notifications;


namespace PaymentContext.Shared.Entities{

    public abstract class Entity : Notifiable  {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        
    }
}