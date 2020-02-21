using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookWorld
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int WorldId { get; set; }
        public World World { get; set; }
    }
}
