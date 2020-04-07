using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserCharacterConfiguration : IEntityTypeConfiguration<UserCharacter>
    {
        public void Configure(EntityTypeBuilder<UserCharacter> builder)
        {
            builder.HasKey(b => new { b.UserId, b.CharacterId });

            builder.HasOne(b => b.User)
                .WithMany(uc => uc.UserCharacters)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(c => c.Character)
                .WithMany(uc => uc.UserCharacters)
                .HasForeignKey(c => c.CharacterId);
        }
    }
}
