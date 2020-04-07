using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserStructureConfiguration : IEntityTypeConfiguration<UserStructure>
    {
        public void Configure(EntityTypeBuilder<UserStructure> builder)
        {
            builder.HasKey(b => new { b.UserId, b.StructureId });

            builder.HasOne(b => b.User)
                .WithMany(us => us.UserStructures)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(s => s.Structure)
                .WithMany(us => us.UserStructures)
                .HasForeignKey(s => s.StructureId);
        }
    }
}
