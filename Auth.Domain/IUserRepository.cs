using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Domain
{
    public interface IUserRepository
    {
        void Create(User user);
        void UpdateProfile(User user);
        Task<User> Login(string email, string password, string applicationId);
        Task<bool> Exist(string email);

    }
}
