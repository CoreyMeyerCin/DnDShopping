using Microsoft.EntityFrameworkCore;

namespace DungeonsAndDragons.Model
{
    public class AppDbcontext : DbContext
    {
        public virtual DbSet<DungeonMaster> DungeonMasters { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<GeneralStore> GeneralStores { get; set; }
        public virtual DbSet<GeneralStoreItems> GeneralStoresItems { get; set; }





    public AppDbcontext() { }
        public AppDbcontext(DbContextOptions<AppDbcontext>options):
            base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(
                    "server=localhost\\sqlexpress;database=dndshoppingserver;trusted_connection=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder) { 
            builder.Entity<DungeonMaster>(e => e.HasIndex(x => x.Id).IsUnique(true));
            builder.Entity<DungeonMaster>(e => e.HasIndex(x => x.Name).IsUnique(true));

            builder.Entity<Player>(e => e.HasIndex(x => x.Id).IsUnique(true));

            builder.Entity<City>(e => e.HasIndex(x => x.Id).IsUnique(true));
            builder.Entity<City>(e => e.HasIndex(x =>x.Name).IsUnique(true));

            builder.Entity<Shop>(e => e.HasIndex(x => x.Id).IsUnique(true));

            builder.Entity<Campaign>(e => e.HasIndex(x => x.Id).IsUnique(true));

            builder.Entity<Item>(e => e.HasIndex(x => x.Id).IsUnique(true));

            builder.Entity<GeneralStore>(e => e.HasIndex(x => x.Id).IsUnique(true));
            builder.Entity<GeneralStoreItems>(e => e.HasIndex(x => x.Id).IsUnique(true));






        }
    }
}
