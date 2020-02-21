using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookWorldConfiguration : IEntityTypeConfiguration<BookWorld>
    {
        public void Configure(EntityTypeBuilder<BookWorld> builder)
        {
            builder.HasKey(b => new { b.BookId, b.WorldId });

            builder.HasOne(b => b.Book)
                .WithMany(bw => bw.BookWorlds)
                .HasForeignKey(b => b.BookId);

            builder.HasOne(w => w.World)
                .WithMany(u => u.BookWorlds)
                .HasForeignKey(w => w.WorldId);
        }
    }
}
