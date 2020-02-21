using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookPlace
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int PlaceId { get; set; }
        public Place Place { get; set; }
    }
}
