using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class GovernmentConfiguration : IEntityTypeConfiguration<Government>
    {
        public void Configure(EntityTypeBuilder<Government> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(n => n.Name);

            builder.HasOne(u => u.User)
                .WithMany(g => g.Governments);
        }
    }
}
