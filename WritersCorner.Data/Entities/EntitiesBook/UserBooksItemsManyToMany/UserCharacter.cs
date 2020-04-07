using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany
{
    public class UserCharacter
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
