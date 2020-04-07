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

            //builder.HasMany(c => c.UserCharacters)
            //    .WithOne(b => b.Book);

            //builder.HasMany(c => c.UserCreatures)
            //    .WithOne(b => b.Book);

            //builder.HasMany(c => c.UserItems)
            //    .WithOne(b => b.Book);

            //builder.HasMany(c => c.UserPlaces)
            //    .WithOne(b => b.Book);

            //builder.HasMany(c => c.UserStratums)
            //    .WithOne(b => b.Book);

            //builder.HasMany(c => c.UserStructures)
            //    .WithOne(b => b.Book);

            //builder.HasMany(c => c.UserTimelines)
            //    .WithOne(b => b.Book);

            //builder.HasMany(c => c.UserWorlds)
            //    .WithOne(b => b.Book);
        }
    }
}
