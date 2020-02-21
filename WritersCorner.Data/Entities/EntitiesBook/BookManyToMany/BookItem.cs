using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookItem
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
