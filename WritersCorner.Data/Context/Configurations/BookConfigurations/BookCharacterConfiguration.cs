using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookCharacterConfiguration : IEntityTypeConfiguration<BookCharacter>
    {
        public void Configure(EntityTypeBuilder<BookCharacter> builder)
        {
            builder.HasKey(b => new { b.BookId, b.CharacterId });

            builder.HasOne(b => b.Book)
                .WithMany(bc => bc.BookCharacters)
                .HasForeignKey(b => b.BookId);

            builder.HasOne(c => c.Character)
                .WithMany(bc => bc.BookCharacters)
                .HasForeignKey(c => c.CharacterId);
        }
    }
}
