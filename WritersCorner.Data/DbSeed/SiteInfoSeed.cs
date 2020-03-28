using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities;

namespace WritersCorner.Data.DbSeed
{
    public static class SiteInfoSeed
    {
        public static void UpdateSiteInfo(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteInfo>().HasData(new SiteInfo
            {
                Id = 1,

                AboutUs = "Set About us here...",
                ContactUs = "Set contact us here...",
                FAQ = "Set FAQ here...",

                UserId = "1",
            });
        }
    }
}
