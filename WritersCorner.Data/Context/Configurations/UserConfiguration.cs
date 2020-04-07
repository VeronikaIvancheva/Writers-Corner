using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities;

namespace WritersCorner.Data.Context.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(i => i.Role)
                .IsRequired();

            builder.HasMany(b => b.Book)
                 .WithOne(u => u.User);

            builder.HasMany(c => c.UserCharacters)
                .WithOne(b => b.User);

            builder.HasMany(c => c.UserCreatures)
                .WithOne(b => b.User);

            builder.HasMany(c => c.UserItems)
                .WithOne(b => b.User);

            builder.HasMany(c => c.UserPlaces)
                .WithOne(b => b.User);

            builder.HasMany(c => c.UserStratums)
                .WithOne(b => b.User);

            builder.HasMany(c => c.UserStructures)
                .WithOne(b => b.User);

            builder.HasMany(c => c.UserTimelines)
                .WithOne(b => b.User);

            builder.HasMany(c => c.UserWorlds)
                .WithOne(b => b.User);
        }
    }
}
