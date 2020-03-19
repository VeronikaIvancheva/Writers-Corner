using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WritersCorner.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Book = new List<Book>();
            this.SiteInfo = new List<SiteInfo>();
        }

        [Required]
        public string Role { get; set; }

        public string Name { get; set; }

        public DateTime? RegisterOn { get; set; }
        public bool IsBanned { get; set; }
        public int BansCount { get; set; }
        public int BanDays { get; set; }
        public string BanReason { get; set; }
        public string BanedFrom { get; set; }
        public DateTime? BanRemovedDate { get; set; }

        public ICollection<Book> Book { get; set; }
        public ICollection<SiteInfo> SiteInfo { get; set; }
    }
}
