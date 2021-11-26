using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateDate { get; set; }
        public String Desc { get; set; }
        public bool Status { get; set; }

    }
}
