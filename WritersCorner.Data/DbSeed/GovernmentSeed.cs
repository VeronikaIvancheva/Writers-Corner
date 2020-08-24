using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class GovernmentSeed
    {
        public static void UpdateGovernment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Government>().HasData(new Government
            {
                Id = 1,
                //TODO
            });
        }
    }
}
