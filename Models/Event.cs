using System;

namespace Brunel_Sailing_Web.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Tags { get; set; }
        public string ShortDesc { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public User Author { get; set; }
    }
}