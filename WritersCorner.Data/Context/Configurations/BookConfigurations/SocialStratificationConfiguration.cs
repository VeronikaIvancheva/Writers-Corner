using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class SocialStratificationConfiguration : IEntityTypeConfiguration<SocialStratification>
    {
        public void Configure(EntityTypeBuilder<SocialStratification> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(n => n.Name);

            builder.HasOne(u => u.User)
                .WithMany(ss => ss.SocialStratifications);
        }
    }
}
