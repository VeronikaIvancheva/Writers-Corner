
using System.Collections.Generic;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    //TODO
    public class Timeline
    {
        public Timeline()
        {
            this.BookTimelines = new List<BookTimeline>();
        }

        public int Id { get; set; }

        public ICollection<BookTimeline> BookTimelines { get; set; }
    }
}
