using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Context.Configurations.BookConfigurations
{
    public class BookStratumConfiguration : IEntityTypeConfiguration<BookStratum>
    {
            public void Configure(EntityTypeBuilder<BookStratum> builder)
            {
                builder.HasKey(b => new { b.BookId, b.StratumId });

                builder.HasOne(b => b.Book)
                    .WithMany(bs => bs.BookStratums)
                    .HasForeignKey(b => b.BookId);

                builder.HasOne(s => s.Stratum)
                    .WithMany(bs => bs.BookStratums)
                    .HasForeignKey(s => s.StratumId);
            }
    }
}
