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

        public async Task CreateUserAsync(User user)
        {
            Create(user);
            await SaveAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            Delete(user);
            await SaveAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await FindAll().OrderBy(x => x.FirstName).ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await FindByCondition(u => u.UserId.Equals(id)).DefaultIfEmpty(new User()).SingleAsync();
        }

        public async Task UpdateUserAsync(User dbUser, User user)
        {
            dbUser.Map(user);
            Update(dbUser);
            await SaveAsync();
        }
    }
        
}
