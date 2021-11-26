using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Role
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Desc { get; set; }
        public bool Status { get; set; }
    }
}
