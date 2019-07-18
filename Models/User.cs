using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
