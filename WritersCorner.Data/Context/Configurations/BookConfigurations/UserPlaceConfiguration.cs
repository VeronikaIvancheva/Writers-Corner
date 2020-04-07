using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserPlaceConfiguration : IEntityTypeConfiguration<UserPlace>
    {
        public void Configure(EntityTypeBuilder<UserPlace> builder)
        {
            builder.HasKey(b => new { b.UserId, b.PlaceId });

            builder.HasOne(b => b.User)
                .WithMany(up => up.UserPlaces)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(p => p.Place)
                .WithMany(up => up.UserPlaces)
                .HasForeignKey(p => p.PlaceId);
        }
    }
}
