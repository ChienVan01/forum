using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forum.Models;

namespace Forum.Data
{
    public class ForumContext : DbContext
    {
        public ForumContext (DbContextOptions<ForumContext> options)
            : base(options)
        {
        }

        public DbSet<Forum.Models.User> Users { get; set; }
        public DbSet<Forum.Models.Topic> Topics { get; set; }
        public DbSet<Forum.Models.Comment> Comments { get; set; }
        public DbSet<Forum.Models.Role> Roles { get; set; }
    }
}
