using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserItemConfiguration : IEntityTypeConfiguration<UserItem>
    {
        public void Configure(EntityTypeBuilder<UserItem> builder)
        {
            builder.HasKey(b => new { b.UserId, b.ItemId });

            builder.HasOne(b => b.User)
                .WithMany(ui => ui.UserItems)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(i => i.Item)
                .WithMany(ui => ui.UserItems)
                .HasForeignKey(i => i.ItemId);
        }
    }
}
