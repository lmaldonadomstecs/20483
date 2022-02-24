using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myWebAPI.Model;

namespace myWebAPI.Data
{
    public class PostsContext : DbContext
    {
        public PostsContext(DbContextOptions<PostsContext> options) : base(options)
        { }

        public DbSet<Post> post { get; set; } = null!;
    }
}
