using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brunel_Sailing_Web.Data;
using Brunel_Sailing_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Brunel_Sailing_Web.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) :base(context)
        {

        }

        public Task CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await FindAll().OrderBy(x => x.FirstName).ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await FindByCondition(u => u.UserId.Equals(id)).DefaultIfEmpty(new User()).SingleAsync();
        }

        public Task UpdateUserAsync(User dbUser, User user)
        {
            throw new NotImplementedException();
        }
    }
        
}
