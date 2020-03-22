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

                AboutUs = "Some random text for about us thing",
                ContactUs = "Some random text for contact us thing",
                FAQ = "For more information or any questions please contact the admins.",
            });
        }
    }
}
