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

        public DateTime? RegisterOn { get; set; }
        public int BansCount { get; set; }

        public ICollection<Book> Book { get; set; }
        public ICollection<SiteInfo> SiteInfo { get; set; }
    }
}
