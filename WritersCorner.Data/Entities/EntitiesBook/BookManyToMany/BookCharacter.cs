using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookCharacter
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
