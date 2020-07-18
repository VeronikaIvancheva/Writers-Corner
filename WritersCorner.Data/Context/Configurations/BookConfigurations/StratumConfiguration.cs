using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class StratumConfiguration : IEntityTypeConfiguration<Stratum>
    {
        public void Configure(EntityTypeBuilder<Stratum> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(bn => bn.Name);

            builder.HasOne(u => u.User)
                .WithMany(s => s.Stratums);
        }
    }
}
