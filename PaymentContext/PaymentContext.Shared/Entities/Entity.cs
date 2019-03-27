using System;
using System.Collections;
using System.Collections.Generic;

namespace PaymentContext.Shared.Entities{

    public abstract class Entity {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        
    }
}