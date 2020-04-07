using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany
{
    public class UserTimeline
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int TimelineId { get; set; }
        public Timeline Timeline { get; set; }
    }
}
