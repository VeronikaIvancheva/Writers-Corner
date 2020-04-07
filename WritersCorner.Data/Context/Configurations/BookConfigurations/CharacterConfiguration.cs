using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(bn => bn.Name)
                .IsRequired();

            builder.HasMany(bc => bc.UserCharacters)
                 .WithOne(c => c.Character);
        }
    }
}
