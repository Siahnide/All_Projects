using Microsoft.EntityFrameworkCore;
using Wedding_Planner.Models;

public class WeddingContext : DbContext
{
    public WeddingContext(DbContextOptions<WeddingContext> options) : base(options) { }
    public DbSet<RegUser> Users { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    
    
}