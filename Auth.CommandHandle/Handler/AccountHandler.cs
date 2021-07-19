using Auth.CommandHandle.Commands.Account;
using Auth.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.CommandHandle.Handler
{
    public class AccountHandler:IAsyncCommandHandler<UserCreateCommand>
    {
        private readonly UserRepository _userRepository;

        public AccountHandler(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task HandleAsync(UserCreateCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
