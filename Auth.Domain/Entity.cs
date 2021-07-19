using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Domain
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeleteddOn { get; set; }
    }
}
