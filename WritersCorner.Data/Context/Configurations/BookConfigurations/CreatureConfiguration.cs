using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class CreatureConfiguration : IEntityTypeConfiguration<Creature>
    {
        public void Configure(EntityTypeBuilder<Creature> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(bn => bn.Name)
                .IsRequired();

            builder.HasMany(bc => bc.BookCreatures)
                 .WithOne(c => c.Creature);
        }
    }
}
