using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Domain
{
    public class Customer: Entity
    {
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        protected Customer() { }


        public string Name { get; private set; }
        public string Email { get; private set; }
        public IList<User> Users { get; set; }
    }
}
