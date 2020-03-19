using System;
using WritersCorner.Data.Entities;

namespace WritersCorner.Models.UserViewModel
{
    public class UserViewModel
    {
        public UserViewModel() { }

        public UserViewModel(User user)
        {
            this.Id = user.Id;
            this.Username = user.UserName;
            this.Name = user.Name;
            this.Role = user.Role;
            this.Email = user.Email;
            this.RegisterOn = user.RegisterOn;
            this.BanEnd = user.LockoutEnd;
            this.BanRemovedDate = user.BanRemovedDate;
            this.BansCount = user.BansCount;
            this.BanReason = user.BanReason;
            this.BanDays = user.BanDays;
            this.BanedFrom = user.BanedFrom;
            this.IsBanned = user.IsBanned;
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public DateTime? RegisterOn { get; set; }
        public DateTimeOffset? BanEnd { get; set; }
        public DateTimeOffset? BanRemovedDate { get; set; }
        public int BansCount { get; set; }
        public string BanReason { get; set; }
        public int BanDays { get; set; }
        public string BanedFrom { get; set; }
        public bool IsBanned { get; set; }
    }

}
