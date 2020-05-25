﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            this.SiteInfo = new List<SiteInfo>();
            this.Book = new List<Book>();

            this.Characters = new List<Character>();
            this.Creatures = new List<Creature>();
            this.Items = new List<Item>();
            this.Places = new List<Place>();
            this.Stratums = new List<Stratum>();
            this.Structures = new List<Structure>();
            this.Timelines = new List<Timeline>();
            this.Worlds = new List<World>();
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


        public ICollection<SiteInfo> SiteInfo { get; set; }

        public ICollection<Book> Book { get; set; }
        public ICollection<Character> Characters { get; set; }
        public ICollection<Creature> Creatures { get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<Place> Places { get; set; }
        public ICollection<Stratum> Stratums { get; set; }
        public ICollection<Structure> Structures { get; set; }
        public ICollection<Timeline> Timelines { get; set; }
        public ICollection<World> Worlds { get; set; }
    }
}
