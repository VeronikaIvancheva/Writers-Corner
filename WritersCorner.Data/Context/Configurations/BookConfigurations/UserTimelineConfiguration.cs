using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class UserTimelineConfiguration : IEntityTypeConfiguration<UserTimeline>
    {
        public void Configure(EntityTypeBuilder<UserTimeline> builder)
        {
            builder.HasKey(b => new { b.UserId, b.TimelineId });

            builder.HasOne(b => b.User)
                .WithMany(ut => ut.UserTimelines)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(t => t.Timeline)
                .WithMany(ut => ut.UserTimelines)
                .HasForeignKey(t => t.TimelineId);
        }
    }
}
