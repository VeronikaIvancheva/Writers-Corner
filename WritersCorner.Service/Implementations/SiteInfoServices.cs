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
    public class SiteInfoServices : ISiteinfoServices
    {
        private readonly WritersCornerContext _context;

        public SiteInfoServices(WritersCornerContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        #region Contact Us methods

        public async Task<SiteInfo> GetContactUsAsync(string contactUs)
        {
            SiteInfo siteContactUs = await _context.SiteInfos
                .FirstOrDefaultAsync(c => c.ContactUs == contactUs);

            if (siteContactUs == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoContactUs);
            }

            return siteContactUs;
        }

        public async Task<SiteInfo> EditContactUsAsync(string oldContactUs, string newContactUs)
        {
            SiteInfo currentContactUs = await GetContactUsAsync(oldContactUs);

            if (currentContactUs == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoContactUs);
            }

            try
            {
                currentContactUs.ContactUs = newContactUs;
                _context.Update(currentContactUs);
                await _context.SaveChangesAsync();

                return currentContactUs;
            }
            catch (GlobalException)
            {
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteContactUsAsync(string contactUs)
        {
            SiteInfo getContactUs = await GetContactUsAsync(contactUs);

            if (getContactUs == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoContactUs);
            }

            try
            {
                getContactUs.ContactUs = "";
                _context.Update(getContactUs);
                await _context.SaveChangesAsync();

                return getContactUs;
            }
            catch (GlobalException)
            {
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion
        

        #region About Us methods

        public async Task<SiteInfo> GetAboutUsAsync(string aboutUs)
        {
            SiteInfo siteAboutUs = await _context.SiteInfos
                .FirstOrDefaultAsync(c => c.AboutUs == aboutUs);

            if (siteAboutUs == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoAboutUs);
            }

            return siteAboutUs;
        }

        public async Task<SiteInfo> EditAboutUsAsync(string oldAboutUs, string newAboutUs)
        {
            SiteInfo currentAboutUs = await GetAboutUsAsync(oldAboutUs);

            if (currentAboutUs == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoAboutUs);
            }

            try
            {
                currentAboutUs.AboutUs = newAboutUs;
                _context.Update(currentAboutUs);
                await _context.SaveChangesAsync();

                return currentAboutUs;
            }
            catch (GlobalException)
            {
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteAboutUsAsync(string aboutUs)
        {
            SiteInfo getAboutUs = await GetAboutUsAsync(aboutUs);

            if (getAboutUs == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoAboutUs);
            }

            try
            {
                getAboutUs.AboutUs = "";
                _context.Update(getAboutUs);
                await _context.SaveChangesAsync();

                return getAboutUs;
            }
            catch (GlobalException)
            {
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion


        #region FAQ methods

        public async Task<SiteInfo> GetFAQAsync(string faq)
        {
            SiteInfo siteFAQ = await _context.SiteInfos
                .FirstOrDefaultAsync(f => f.FAQ == faq);

            if (siteFAQ == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoFAQ);
            }

            return siteFAQ;
        }

        public async Task<SiteInfo> EditFAQAsync(string oldFAQ, string newFAQ)
        {
            SiteInfo currentFAQ = await GetFAQAsync(oldFAQ);

            if (currentFAQ == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoFAQ);
            }

            try
            {
                currentFAQ.FAQ = newFAQ;
                _context.Update(currentFAQ);
                await _context.SaveChangesAsync();

                return currentFAQ;
            }
            catch (GlobalException)
            {
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteFAQAsync(string faq)
        {
            SiteInfo getFAQ = await GetFAQAsync(faq);

            if (getFAQ == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoFAQ);
            }

            try
            {
                getFAQ.FAQ = "";
                _context.Update(getFAQ);
                await _context.SaveChangesAsync();

                return getFAQ;
            }
            catch (GlobalException)
            {
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion

        #region All

        public async Task<IEnumerable<SiteInfo>> GetAllAsync()
        {
            IEnumerable<SiteInfo> allSi = await _context.SiteInfos
                .ToListAsync();

            return allSi;
        }
        #endregion
    }
}
