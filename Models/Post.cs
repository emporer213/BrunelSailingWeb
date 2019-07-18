using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Tags { get; set; }
        public string ShortDesc { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public int UserId { get; set; }

        public User Author { get; set; }
    }
}
