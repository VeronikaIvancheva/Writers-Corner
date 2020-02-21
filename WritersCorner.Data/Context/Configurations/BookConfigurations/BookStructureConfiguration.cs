using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookStructureConfiguration : IEntityTypeConfiguration<BookStructure>
    {
        public void Configure(EntityTypeBuilder<BookStructure> builder)
        {
            builder.HasKey(b => new { b.BookId, b.StructureId });

            builder.HasOne(b => b.Book)
                .WithMany(bs => bs.BookStructures)
                .HasForeignKey(b => b.BookId);

            builder.HasOne(s => s.Structure)
                .WithMany(bs => bs.BookStructures)
                .HasForeignKey(s => s.StructureId);
        }
    }
}
