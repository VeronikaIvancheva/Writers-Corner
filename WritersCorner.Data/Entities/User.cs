using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Book = new List<Book>();
            this.SiteInfo = new List<SiteInfo>();

            this.UserCharacters = new List<UserCharacter>();
            this.UserCreatures = new List<UserCreature>();
            this.UserItems = new List<UserItem>();
            this.UserPlaces = new List<UserPlace>();
            this.UserStratums = new List<UserStratum>();
            this.UserStructures = new List<UserStructure>();
            this.UserTimelines = new List<UserTimeline>();
            this.UserWorlds = new List<UserWorld>();
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

        public ICollection<UserCharacter> UserCharacters { get; set; }
        public ICollection<UserCreature> UserCreatures { get; set; }
        public ICollection<UserItem> UserItems { get; set; }
        public ICollection<UserPlace> UserPlaces { get; set; }
        public ICollection<UserStratum> UserStratums { get; set; }
        public ICollection<UserStructure> UserStructures { get; set; }
        public ICollection<UserTimeline> UserTimelines { get; set; }
        public ICollection<UserWorld> UserWorlds { get; set; }
    }
}
