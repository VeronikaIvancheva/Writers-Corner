using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserCreatureConfiguration : IEntityTypeConfiguration<UserCreature>
    {
        public void Configure(EntityTypeBuilder<UserCreature> builder)
        {
            builder.HasKey(b => new { b.UserId, b.CreatureId });

            builder.HasOne(b => b.User)
                .WithMany(uc => uc.UserCreatures)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(c => c.Creature)
                .WithMany(uc => uc.UserCreatures)
                .HasForeignKey(c => c.CreatureId);
        }
    }
}
