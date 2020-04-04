using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities;

namespace WritersCorner.Service.Contracts
{
    public interface ISiteinfoServices
    {
        //Contact Us
        Task<SiteInfo> GetContactUsAsync(string contactUs);
        Task<SiteInfo> EditContactUsAsync(string oldContactUs, string newContactUs);
        Task<SiteInfo> DeleteContactUsAsync(string contactUs);

        //About Us
        Task<SiteInfo> GetAboutUsAsync(string aboutUs);
        Task<SiteInfo> EditAboutUsAsync(string oldAboutUs, string newAboutUs);
        Task<SiteInfo> DeleteAboutUsAsync(string aboutUs);

        //FAQ
        Task<SiteInfo> GetFAQAsync(string faq);
        Task<SiteInfo> EditFAQAsync(string oldFAQ, string newFAQ);
        Task<SiteInfo> DeleteFAQAsync(string faq);

        //All
        Task<IEnumerable<SiteInfo>> GetAllAsync();
    }
}
