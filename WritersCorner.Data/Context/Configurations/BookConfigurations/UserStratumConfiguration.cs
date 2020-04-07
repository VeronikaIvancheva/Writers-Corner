using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserStratumConfiguration : IEntityTypeConfiguration<UserStratum>
    {
            public void Configure(EntityTypeBuilder<UserStratum> builder)
            {
                builder.HasKey(b => new { b.UserId, b.StratumId });

                builder.HasOne(b => b.User)
                    .WithMany(us => us.UserStratums)
                    .HasForeignKey(b => b.UserId);

                builder.HasOne(s => s.Stratum)
                    .WithMany(us => us.UserStratums)
                    .HasForeignKey(s => s.StratumId);
            }
    }
}
