﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

            return siteContactUs;
        }

        public async Task<SiteInfo> EditContactUsAsync(string oldContactUs, string newContactUs)
        {
            SiteInfo currentContactUs = await GetContactUsAsync(oldContactUs);

            try
            {
                currentContactUs.ContactUs = newContactUs;
                _context.Update(currentContactUs);
                await _context.SaveChangesAsync();

                return currentContactUs;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteContactUsAsync(string contactUs)
        {
            SiteInfo getContactUs = await GetContactUsAsync(contactUs);

            try
            {
                getContactUs.ContactUs = "";
                _context.Update(getContactUs);
                await _context.SaveChangesAsync();

                return getContactUs;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion
        

        #region About Us methods

        public async Task<SiteInfo> GetAboutUsAsync(string aboutUs)
        {
            SiteInfo siteAboutUs = await _context.SiteInfos
                .FirstOrDefaultAsync(c => c.AboutUs == aboutUs);

            return siteAboutUs;
        }

        public async Task<SiteInfo> EditAboutUsAsync(string oldAboutUs, string newAboutUs)
        {
            SiteInfo currentAboutUs = await GetAboutUsAsync(oldAboutUs);

            try
            {
                currentAboutUs.AboutUs = newAboutUs;
                _context.Update(currentAboutUs);
                await _context.SaveChangesAsync();

                return currentAboutUs;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteAboutUsAsync(string aboutUs)
        {
            SiteInfo getAboutUs = await GetAboutUsAsync(aboutUs);

            try
            {
                getAboutUs.AboutUs = "";
                _context.Update(getAboutUs);
                await _context.SaveChangesAsync();

                return getAboutUs;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion


        #region FAQ methods

        public async Task<SiteInfo> GetFAQAsync(string faq)
        {
            SiteInfo siteFAQ = await _context.SiteInfos
                .FirstOrDefaultAsync(f => f.FAQ == faq);

            return siteFAQ;
        }

        public async Task<SiteInfo> EditFAQAsync(string oldFAQ, string newFAQ)
        {
            SiteInfo currentFAQ = await GetFAQAsync(oldFAQ);

            try
            {
                currentFAQ.FAQ = newFAQ;
                _context.Update(currentFAQ);
                await _context.SaveChangesAsync();

                return currentFAQ;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<SiteInfo> DeleteFAQAsync(string faq)
        {
            SiteInfo getFAQ = await GetFAQAsync(faq);

            try
            {
                getFAQ.FAQ = "";
                _context.Update(getFAQ);
                await _context.SaveChangesAsync();

                return getFAQ;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }

        }
        #endregion

        #region All

        public async Task<IEnumerable<SiteInfo>> GetAllAsync()
        {
            IEnumerable<SiteInfo> allSiteInfo = await _context.SiteInfos
                .ToListAsync();

            return allSiteInfo;
        }
        #endregion
    }
}
