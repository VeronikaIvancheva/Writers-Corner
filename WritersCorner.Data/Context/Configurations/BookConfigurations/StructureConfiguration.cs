using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class StructureConfiguration : IEntityTypeConfiguration<Structure>
    {
        public void Configure(EntityTypeBuilder<Structure> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(bn => bn.Name)
                .IsRequired();

            builder.HasMany(bs => bs.UserStructures)
                 .WithOne(s => s.Structure);
        }
    }
}
