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

            builder.HasMany(c => c.Characters)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Countries)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Floras)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Governments)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Creatures)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Items)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Places)
                .WithOne(b => b.User);

            builder.HasMany(c => c.SocialStratifications)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Structures)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Timelines)
                .WithOne(b => b.User);

            builder.HasMany(c => c.Worlds)
                .WithOne(b => b.User);
        }
    }
}
