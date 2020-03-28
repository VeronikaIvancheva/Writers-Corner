using System.Collections.Generic;
using WritersCorner.Models.HomeVM;

namespace WritersCorner.Models.HomeVM
{
    public class HomeIndexViewModel
    {
        public IEnumerable<HomeViewModel> SiteInfo { get; set; }
    }
}
