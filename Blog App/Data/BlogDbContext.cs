using Microsoft.EntityFrameworkCore;
using Blog_App.Models.Domain;


namespace Blog_App.Data
{   
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
       
    }
}
