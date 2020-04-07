using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserWorldConfiguration : IEntityTypeConfiguration<UserWorld>
    {
        public void Configure(EntityTypeBuilder<UserWorld> builder)
        {
            builder.HasKey(b => new { b.UserId, b.WorldId });

            builder.HasOne(b => b.User)
                .WithMany(bw => bw.UserWorlds)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(w => w.World)
                .WithMany(u => u.UserWorlds)
                .HasForeignKey(w => w.WorldId);
        }
    }
}
