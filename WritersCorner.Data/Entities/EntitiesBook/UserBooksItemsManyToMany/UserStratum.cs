using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany
{
    public class UserStratum
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int StratumId { get; set; }
        public Stratum Stratum { get; set; }
    }
}
