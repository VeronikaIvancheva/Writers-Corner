using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookItemConfiguration : IEntityTypeConfiguration<BookItem>
    {
        public void Configure(EntityTypeBuilder<BookItem> builder)
        {
            builder.HasKey(b => new { b.BookId, b.ItemId });

            builder.HasOne(b => b.Book)
                .WithMany(bi => bi.BookItems)
                .HasForeignKey(b => b.BookId);

            builder.HasOne(i => i.Item)
                .WithMany(bi => bi.BookItems)
                .HasForeignKey(i => i.ItemId);
        }
    }
}
