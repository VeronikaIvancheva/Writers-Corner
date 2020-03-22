using System.Collections.Generic;
using WritersCorner.Data.Entities;

namespace WritersCorner.Models.HomeVm
{
    public class HomeViewModel
    {
        public HomeViewModel() {}

        public HomeViewModel(SiteInfo siteInfo)
        {
            this.ContactUs = siteInfo.ContactUs;
            this.AboutUs = siteInfo.AboutUs;
            this.FAQ = siteInfo.FAQ;
        }

        public string ContactUs { get; set; }
        public string AboutUs { get; set; }
        public string FAQ { get; set; }
    }
}
