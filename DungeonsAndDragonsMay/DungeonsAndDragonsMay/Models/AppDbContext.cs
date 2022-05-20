using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragonsMay.Models
{
    public class AppDbContext:DbContext {
        public virtual DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("server=localhost\\sqlexpress; database=dndShoppingServer;trusted_connection=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<User>(e => e.HasIndex(x => x.Id).IsUnique(true));
        }
    }
}
