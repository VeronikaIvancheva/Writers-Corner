using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WritersCorner.Data.Entities;
using WritersCorner.Mappers;
using WritersCorner.Models;
using WritersCorner.Service.Contracts;

namespace WritersCorner.Controllers
{
    //TODO - to move it to another controller? // SiteInfo Controller
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISiteinfoServices _siteInfoServices;

        public HomeController(ILogger<HomeController> logger, ISiteinfoServices siteInfoServices)
        {
            this._logger = logger;
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
                ICollection<SiteInfo> allSi = await _siteInfoServices.GetAll();

                //var siteInfoModel = SiteInfoMapper.MapSiteInfo(allSi);

                var siteInfoListing = allSi
                .Select(m => SiteInfoMapper.MapSiteInfo(m));

                return View("Index", siteInfoListing);
            }
            catch (Exception e)
            {
                //TODO - pop-up message - not new page?
                return BadRequest(e.Message);
            }
        }
    }
}
