using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany
{
    public class UserPlace
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int PlaceId { get; set; }
        public Place Place { get; set; }
    }
}
