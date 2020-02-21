using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookTimeline
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int TimelineId { get; set; }
        public Timeline Timeline { get; set; }
    }
}
