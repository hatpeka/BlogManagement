using BlogManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Data
{
    public class BlogDbContext: DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options): base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Rating> Rating { get; set; }
    }
}
