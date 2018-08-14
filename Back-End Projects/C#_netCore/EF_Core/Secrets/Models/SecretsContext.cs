using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Secrets.Models;

public class SecretsContext : DbContext
{
    public SecretsContext(DbContextOptions<SecretsContext> options) : base(options) { }
    public DbSet<RegUser> users { get; set; }
    public DbSet<Secret> secrets { get; set; }
    public DbSet<Like> likes { get; set; }
}