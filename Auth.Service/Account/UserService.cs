using Auth.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Service.Account
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            _userRepository.Create(user);
        }

        public void ForgotPassword(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> Login(string email, string password, string applicationId)
        {
            return _userRepository.Login(email, password, applicationId);
        }

        public void ResetPassword(string password)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfile(User user)
        {
            _userRepository.UpdateProfile(user);
        }
    }
}
