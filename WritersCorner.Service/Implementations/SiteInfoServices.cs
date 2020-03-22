using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WritersCorner.Data.Context;
using WritersCorner.Data.Entities;
using WritersCorner.Service.Contracts;
using WritersCorner.Service.CustomException;

namespace WritersCorner.Service.Implementations
{
    public class SiteInfoServices : ISiteInfoServices
    {
        private readonly WritersCornerContext _context;

        public SiteInfoServices(WritersCornerContext context)
        {
            this._context = context;
        }

        #region Contact Us methods

        public async Task<SiteInfo> GetContactUs(string contactUs)
        {
            SiteInfo siteContactUs = await _context.SiteInfos
                .FirstOrDefaultAsync(c => c.ContactUs == contactUs);

            if (siteContactUs == null)
            {
                throw new Exception(ExceptionMessage.NoContactUs);
            }

            return siteContactUs;
        }

        public async Task<SiteInfo> EditContactUs(string oldContactUs, string newContactUs)
        {
            SiteInfo currentContactUs = await GetContactUs(oldContactUs);

            if (currentContactUs == null)
            {
                throw new Exception(ExceptionMessage.NoContactUs);
            }

            try
            {
                currentContactUs.ContactUs = newContactUs;
                _context.Update(currentContactUs);
                await _context.SaveChangesAsync();

                return currentContactUs;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteContactUs(string contactUs)
        {
            SiteInfo getContactUs = await GetContactUs(contactUs);

            if (getContactUs == null)
            {
                throw new Exception(ExceptionMessage.NoContactUs);
            }

            try
            {
                getContactUs.ContactUs = "";
                _context.Update(getContactUs);
                await _context.SaveChangesAsync();

                return getContactUs;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion
        

        #region About Us methods

        public async Task<SiteInfo> GetAboutUs(string aboutUs)
        {
            SiteInfo siteAboutUs = await _context.SiteInfos
                .FirstOrDefaultAsync(c => c.AboutUs == aboutUs);

            if (siteAboutUs == null)
            {
                throw new Exception(ExceptionMessage.NoAboutUs);
            }

            return siteAboutUs;
        }

        public async Task<SiteInfo> EditAboutUs(string oldAboutUs, string newAboutUs)
        {
            SiteInfo currentAboutUs = await GetAboutUs(oldAboutUs);

            if (currentAboutUs == null)
            {
                throw new Exception(ExceptionMessage.NoAboutUs);
            }

            try
            {
                currentAboutUs.AboutUs = newAboutUs;
                _context.Update(currentAboutUs);
                await _context.SaveChangesAsync();

                return currentAboutUs;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteAboutUs(string aboutUs)
        {
            SiteInfo getAboutUs = await GetAboutUs(aboutUs);

            if (getAboutUs == null)
            {
                throw new Exception(ExceptionMessage.NoAboutUs);
            }

            try
            {
                getAboutUs.AboutUs = "";
                _context.Update(getAboutUs);
                await _context.SaveChangesAsync();

                return getAboutUs;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion


        #region FAQ methods

        public async Task<SiteInfo> GetFAQ(string faq)
        {
            SiteInfo siteFAQ = await _context.SiteInfos
                .FirstOrDefaultAsync(f => f.FAQ == faq);

            if (siteFAQ == null)
            {
                throw new Exception(ExceptionMessage.NoFAQ);
            }

            return siteFAQ;
        }

        public async Task<SiteInfo> EditFAQ(string oldFAQ, string newFAQ)
        {
            SiteInfo currentFAQ = await GetFAQ(oldFAQ);

            if (currentFAQ == null)
            {
                throw new Exception(ExceptionMessage.NoFAQ);
            }

            try
            {
                currentFAQ.FAQ = newFAQ;
                _context.Update(currentFAQ);
                await _context.SaveChangesAsync();

                return currentFAQ;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteFAQ(string faq)
        {
            SiteInfo getFAQ = await GetFAQ(faq);

            if (getFAQ == null)
            {
                throw new Exception(ExceptionMessage.NoFAQ);
            }

            try
            {
                getFAQ.FAQ = "";
                _context.Update(getFAQ);
                await _context.SaveChangesAsync();

                return getFAQ;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion

        #region All

        public async Task<ICollection<SiteInfo>> GetAll()
        {
            ICollection<SiteInfo> allSi = await _context.SiteInfos
                .ToListAsync();

            return allSi;
        }
        #endregion
    }
}
