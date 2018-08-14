using Microsoft.EntityFrameworkCore;
using TheWall.Models;
namespace TheWall.Models
{
    public class WallContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public WallContext(DbContextOptions<WallContext> options) : base(options) { }
        public DbSet<RegUser> users {get;set;}
        public DbSet<Post> posts {get;set;}
        public DbSet<Comment> comments {get;set;}
        
    }
}
