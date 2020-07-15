using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WritersCorner.Data.Entities;
using WritersCorner.Mappers;
using WritersCorner.Models;
using WritersCorner.Models.HomeVM;
using WritersCorner.Service.Contracts;
using WritersCorner.Service.CustomException;

namespace WritersCorner.Controllers
{
    //TODO - to move it to another controller? // SiteInfo Controller
    public class HomeController : Controller
    {
        private readonly ISiteinfoServices _siteInfoServices;

        public HomeController(ISiteinfoServices siteInfoServices)
        {
            this._siteInfoServices = siteInfoServices;
        }

        #region in-build
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            try
            {
                IEnumerable<SiteInfo> allSi = await _siteInfoServices.GetAllAsync();

                //var siteInfoModel = SiteInfoMapper.MapSiteInfo(allSi);

                IEnumerable<HomeViewModel> siteInfoListing = allSi
                .Select(m => SiteInfoMapper.MapSiteInfo(m))
                .ToList();

                HomeIndexViewModel siteInfoModel = SiteInfoMapper.MapFromSiteInfo(siteInfoListing);

                //return View("Index", siteInfoListing);
                return View(siteInfoModel);
                //return View("Index");
            }
            catch (GlobalException e)
            {
                //TODO - pop-up message - not new page?
                return BadRequest(e.Message);
            }
        }
    }
}
