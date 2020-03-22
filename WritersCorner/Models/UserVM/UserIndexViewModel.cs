using System.Collections.Generic;

namespace WritersCorner.Models.UserVM
{
    public class UserIndexViewModel
    {
        public IEnumerable<UserViewModel> Users { get; set; }

        public int? PreviousPage { get; set; }
        public int? NextPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
