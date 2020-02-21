using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.BookManyToMany
{
    public class BookCreature
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int CreatureId { get; set; }
        public Creature Creature { get; set; }
    }
}
