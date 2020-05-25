using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Context.Configurations;
using WritersCorner.Data.Context.Configurations.BookConfigurations;
using WritersCorner.Data.DbSeed;
using WritersCorner.Data.Entities;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context
{
    public class WritersCornerContext : IdentityDbContext<User>
    {
        public WritersCornerContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        #region Book connections
        public DbSet<Character> Characters { get; set; }
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Stratum> Stratums { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Timeline> Timelines { get; set; }
        public DbSet<World> Worlds { get; set; }
        #endregion

        public DbSet<SiteInfo> SiteInfos { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Book Configurations
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            modelBuilder.ApplyConfiguration(new CreatureConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new PlaceConfiguration());
            modelBuilder.ApplyConfiguration(new StratumConfiguration());
            modelBuilder.ApplyConfiguration(new StructureConfiguration());
            modelBuilder.ApplyConfiguration(new TimelineConfiguration());
            modelBuilder.ApplyConfiguration(new WorldConfiguration());
            #endregion

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new SiteInfoConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.UpdateUsers();
            modelBuilder.UpdateCharacter();
            modelBuilder.UpdateCreature();
            modelBuilder.UpdateItem();
            modelBuilder.UpdatePlace();
            modelBuilder.UpdateStratum();
            modelBuilder.UpdateStructure();
            modelBuilder.UpdateWorld();
            modelBuilder.UpdateSiteInfo();

            base.OnModelCreating(modelBuilder);
        }
    }
}
