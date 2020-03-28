using System.Collections.Generic;
using WritersCorner.Data.Entities;
using WritersCorner.Models.HomeVM;

namespace WritersCorner.Mappers
{
    public static class SiteInfoMapper
    {
        public static HomeViewModel MapSiteInfo(this SiteInfo siteInfo)
        {
            if (siteInfo == null)
            {
                return null;
            }

            HomeViewModel siteInfoVM = new HomeViewModel
            {
                ContactUs = siteInfo.ContactUs,
                AboutUs = siteInfo.AboutUs,
                FAQ = siteInfo.FAQ,
            };

            return siteInfoVM;
        }

        public static HomeIndexViewModel MapFromSiteInfo(this IEnumerable<HomeViewModel> siteInfos)
        {
            var model = new HomeIndexViewModel
            {
                SiteInfo = siteInfos
            };

            return model;
        }
    }
}
