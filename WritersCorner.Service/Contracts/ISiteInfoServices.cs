using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities;

namespace WritersCorner.Service.Contracts
{
    public interface ISiteInfoServices
    {
        //Contact Us
        Task<SiteInfo> GetContactUs(string contactUs);
        Task<SiteInfo> EditContactUs(string oldContactUs, string newContactUs);
        Task<SiteInfo> DeleteContactUs(string contactUs);

        //About Us
        Task<SiteInfo> GetAboutUs(string aboutUs);
        Task<SiteInfo> EditAboutUs(string oldAboutUs, string newAboutUs);
        Task<SiteInfo> DeleteAboutUs(string aboutUs);

        //FAQ
        Task<SiteInfo> GetFAQ(string faq);
        Task<SiteInfo> EditFAQ(string oldFAQ, string newFAQ);
        Task<SiteInfo> DeleteFAQ(string faq);

        //All
        Task<ICollection<SiteInfo>> GetAll();
    }
}
