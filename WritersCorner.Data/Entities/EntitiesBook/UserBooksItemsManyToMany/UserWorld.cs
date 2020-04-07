using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany
{
    public class UserWorld
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int WorldId { get; set; }
        public World World { get; set; }
    }
}
