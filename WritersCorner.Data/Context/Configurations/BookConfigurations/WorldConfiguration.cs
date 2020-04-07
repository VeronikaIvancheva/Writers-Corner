﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class WorldConfiguration : IEntityTypeConfiguration<World>
    {
        public void Configure(EntityTypeBuilder<World> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(bn => bn.Name)
                .IsRequired();

            builder.HasMany(bw => bw.UserWorlds)
                 .WithOne(w => w.World);
        }
    }
}
