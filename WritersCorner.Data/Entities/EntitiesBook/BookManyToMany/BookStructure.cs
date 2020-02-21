using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookStructure
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int StructureId { get; set; }
        public Structure Structure { get; set; }
    }
}
