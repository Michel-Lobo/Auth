using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Domain
{
    public class Role: Entity
    {
        public Role(string name)
        {
            Name = name;
        }

        protected Role()
        {

        }

        public string Name { get; private set; }
        public IList<User> Users { get; set; }
    }
}
