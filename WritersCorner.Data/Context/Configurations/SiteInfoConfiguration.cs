using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities;

namespace WritersCorner.Data.Context.Configurations
{
    public class SiteInfoConfiguration : IEntityTypeConfiguration<SiteInfo>
    {
        public void Configure(EntityTypeBuilder<SiteInfo> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasOne(u => u.User)
                 .WithMany(s => s.SiteInfo);
        }
    }
}
