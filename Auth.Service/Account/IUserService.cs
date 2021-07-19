using Auth.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Service.Account
{
    public interface IUserService
    {
        void CreateUser(User user);
        Task<User> Login(string email, string password, string applicationId);
        void UpdateProfile(User user);
        void ResetPassword(string password);
        void ForgotPassword(string email);
        Task<User> GetUserByEmail(string email);
    }
}
