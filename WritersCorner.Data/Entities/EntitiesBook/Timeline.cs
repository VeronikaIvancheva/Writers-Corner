using System.Collections.Generic;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    //TODO
    public class Timeline
    {
        public Timeline()
        {
            this.UserTimelines = new List<UserTimeline>();
        }

        public int Id { get; set; }

        public ICollection<UserTimeline> UserTimelines { get; set; }
    }
}
