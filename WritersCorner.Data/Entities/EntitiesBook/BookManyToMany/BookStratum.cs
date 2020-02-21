using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookStratum
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int StratumId { get; set; }
        public Stratum Stratum { get; set; }
    }
}
