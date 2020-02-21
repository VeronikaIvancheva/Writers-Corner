using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class TimelineConfiguration : IEntityTypeConfiguration<Timeline>
    {
        public void Configure(EntityTypeBuilder<Timeline> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasMany(bt => bt.BookTimelines)
                 .WithOne(t => t.Timeline);
        }
    }
}
