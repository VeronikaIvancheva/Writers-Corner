using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class FloraConfiguration : IEntityTypeConfiguration<Flora>
    {
        public void Configure(EntityTypeBuilder<Flora> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(bn => bn.Name);

            builder.HasOne(u => u.User)
                .WithMany(c => c.Floras);
        }
    }
}
