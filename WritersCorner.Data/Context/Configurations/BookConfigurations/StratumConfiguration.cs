﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class StratumConfiguration : IEntityTypeConfiguration<Stratum>
    {
        public void Configure(EntityTypeBuilder<Stratum> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(bn => bn.Name)
                .IsRequired();

            builder.HasMany(bs => bs.BookStratums)
                 .WithOne(s => s.Stratum);
        }
    }
}
