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
        }
    }
}
