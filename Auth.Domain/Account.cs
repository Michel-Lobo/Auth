using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Domain
{
    public class Account:IAggregateRoot
    {
        public Account(User user)
        {
            User = user;
        }

        public User User { get; private set; }
        public void UpdateProfile(string name)
        {

        }
        public void ResetPassword(string password, string confirmPassword)
        {

        }
       
    }
}
