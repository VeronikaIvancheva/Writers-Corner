﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany
{
    public class UserCreature
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int CreatureId { get; set; }
        public Creature Creature { get; set; }
    }
}
