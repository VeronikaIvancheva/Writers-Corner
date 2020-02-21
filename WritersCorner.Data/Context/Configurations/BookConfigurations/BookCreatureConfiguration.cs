using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookCreatureConfiguration : IEntityTypeConfiguration<BookCreature>
    {
        public void Configure(EntityTypeBuilder<BookCreature> builder)
        {
            builder.HasKey(b => new { b.BookId, b.CreatureId });

            builder.HasOne(b => b.Book)
                .WithMany(bc => bc.BookCreatures)
                .HasForeignKey(b => b.BookId);

            builder.HasOne(c => c.Creature)
                .WithMany(bc => bc.BookCreatures)
                .HasForeignKey(c => c.CreatureId);
        }
    }
}
