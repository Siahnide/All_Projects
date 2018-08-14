using Microsoft.EntityFrameworkCore;
using RegLog.Models;
namespace RegLog.Models
{
    public class LogRegContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public LogRegContext(DbContextOptions<LogRegContext> options) : base(options) { }
        public DbSet<RegUser> users {get;set;}
    }
}
