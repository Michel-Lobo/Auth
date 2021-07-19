using Auth.Common;
using Auth.Data;
using Auth.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthDbContext _dbContext;

        public UserRepository(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        

        public void Create(User user)
        {
            _dbContext.User.Add(user);
            _dbContext.Commit(false);
            
        }

        public async Task<bool> Exist(string email)
        {
            var user = _dbContext.User.FirstOrDefault(p => p.Email == email);
            return user!=null;
        }

        public async Task<User> Login(string email, string password, string applicationId)
        {
            var user =  _dbContext.User.FirstOrDefault(p => p.Email == email && p.Password == Utility.GenerateHashMd5(password) && p.ApplicationId == new Guid(applicationId));
            return user;
        }

        public void UpdateProfile(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            _dbContext.Commit(false);
        }
    }
}
