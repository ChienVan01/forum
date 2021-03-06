using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public int RoleID { get; set; }
        public String Email { get; set; }
        public DateTime Birthday { get; set; }
        public String Address { get; set; }
        public bool Status { get; set; }
    }
}
