using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookTimelineConfiguration : IEntityTypeConfiguration<BookTimeline>
    {
        public void Configure(EntityTypeBuilder<BookTimeline> builder)
        {
            builder.HasKey(b => new { b.BookId, b.TimelineId });

            builder.HasOne(b => b.Book)
                .WithMany(bt => bt.BookTimelines)
                .HasForeignKey(b => b.BookId);

            builder.HasOne(t => t.Timeline)
                .WithMany(bt => bt.BookTimelines)
                .HasForeignKey(t => t.TimelineId);
        }
    }
}
