using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Domain
{
    public class Application: Entity
    {
        public Application(string name)
        {
            Name = name;
        }

        protected Application()
        {

        }

        public string Name { get; private set; }
        public IList<User> Users { get; set; }
    }
}
