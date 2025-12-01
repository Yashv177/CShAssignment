using System;

namespace LibraryManagerLib.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
