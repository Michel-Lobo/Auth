using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.CommandHandle.Commands.Account
{
    public class UserCreateCommand: ICommandHandler
    {
        public UserCreateCommand(string id, string name, string email, string password, string roleId, string applicationId)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            RoleId = roleId;
            ApplicationId = applicationId;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
        public string ApplicationId { get; set; }
    }
}
