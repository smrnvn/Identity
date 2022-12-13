using Identity.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Identity.DAL
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
            Database.EnsureCreated();
        }      
        public DbSet<User> Users { get; set; }
    }
}
