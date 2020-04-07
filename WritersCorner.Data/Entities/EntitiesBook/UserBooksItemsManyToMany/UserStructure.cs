using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany
{
    public class UserStructure
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int StructureId { get; set; }
        public Structure Structure { get; set; }
    }
}
