using WritersCorner.Data.Entities;
using WritersCorner.Models.HomeVm;

namespace WritersCorner.Mappers
{
    public static class SiteInfoMapper
    {
        public static HomeViewModel MapSiteInfo(this SiteInfo siteInfo)
        {
            var siteInfoVM = new HomeViewModel
            {
                ContactUs = siteInfo.ContactUs,
                AboutUs = siteInfo.AboutUs,
                FAQ = siteInfo.FAQ,
            };

            return siteInfoVM;
        }
    }
}
