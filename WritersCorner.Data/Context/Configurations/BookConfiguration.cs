using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities;

namespace WritersCorner.Data.Context.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(bn => bn.Name)
                .IsRequired();

            builder.Property(bip => bip.ImagePath);

            builder.HasMany(c => c.BookCharacters)
                .WithOne(b => b.Book);

            builder.HasMany(c => c.BookCreatures)
                .WithOne(b => b.Book);

            builder.HasMany(c => c.BookItems)
                .WithOne(b => b.Book);

            builder.HasMany(c => c.BookPlaces)
                .WithOne(b => b.Book);

            builder.HasMany(c => c.BookStratums)
                .WithOne(b => b.Book);

            builder.HasMany(c => c.BookStructures)
                .WithOne(b => b.Book);

            builder.HasMany(c => c.BookTimelines)
                .WithOne(b => b.Book);

            builder.HasMany(c => c.BookWorlds)
                .WithOne(b => b.Book);
        }
    }
}
