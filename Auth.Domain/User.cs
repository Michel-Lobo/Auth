using Auth.Common;
using System;

namespace Auth.Domain
{
    public class User: Entity
    {
        protected User()
        {

        }

        public User(string name, string email, Guid roleId, Guid applicationId, Guid customerId, string password, string confirmPassword, Customer customer)
        {
            Name = name;
            Email = email;
            RoleId = roleId;
            ApplicationId = applicationId;
            Password = Utility.GenerateHashMd5(password);
            ConfirmPassword = Utility.GenerateHashMd5(confirmPassword);
            Customer = customer;
        }

        public string Name { get;private set; }
        public string Email { get; private set; }
        public Guid RoleId { get; private set; }
        public Role Role { get; private set; }
        public Guid ApplicationId { get; private set; }
        public Application Application { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword { get; private set; }
        public Guid CustomerId { get; private set; }
        public Customer Customer { get; private set; }
    }
}
