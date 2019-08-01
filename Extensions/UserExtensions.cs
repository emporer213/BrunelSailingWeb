using Brunel_Sailing_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Extentions
{
    public static class UserExtensions
    {
        public static void Map(this User dbUser, User user)
        {
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Username = user.Username;
            dbUser.Password = user.Password;
            dbUser.RoleId = user.RoleId;
        }
    }
}
