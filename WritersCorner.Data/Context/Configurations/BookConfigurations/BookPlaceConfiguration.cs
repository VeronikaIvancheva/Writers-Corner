using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookPlaceConfiguration : IEntityTypeConfiguration<BookPlace>
    {
        public void Configure(EntityTypeBuilder<BookPlace> builder)
        {
            builder.HasKey(b => new { b.BookId, b.PlaceId });

            builder.HasOne(b => b.Book)
                .WithMany(bp => bp.BookPlaces)
                .HasForeignKey(b => b.BookId);

            builder.HasOne(p => p.Place)
                .WithMany(bp => bp.BookPlaces)
                .HasForeignKey(p => p.PlaceId);
        }
    }
}
