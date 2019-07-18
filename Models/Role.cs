using System.Collections.Generic;

namespace Brunel_Sailing_Web.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool CreateUsers { get; set; }
        public bool EditUsers { get; set; }
        public bool DeleteUsers { get; set; }
        public bool SiteConfig { get; set; }
        public bool ManagePermissions { get; set; }
        public bool EditPosts { get; set; }
        public bool CreatePosts { get; set; }
        public bool DeletePosts { get; set; }
        public bool EditEvents { get; set; }
        public bool CreateEvents { get; set; }
        public bool DeleteEvents { get; set; }

        public ICollection<User> Users { get; set; }
    }
}