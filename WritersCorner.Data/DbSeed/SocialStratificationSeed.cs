using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class SocialStratificationSeed
    {
        public static void UpdateSocialStratification(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SocialStratification>().HasData(new SocialStratification
            {
                Id = 1,
                //TODO

            });
        }
    }
}
