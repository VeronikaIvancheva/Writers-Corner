using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class FloraSeed
    {
        public static void UpdateFlora(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flora>().HasData(new Flora
            {
                Id = 1,
                //TODO
            });
        }
    }
}