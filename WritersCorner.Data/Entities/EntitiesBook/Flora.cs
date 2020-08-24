﻿using WritersCorner.Data.Contracts;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    public class Flora : IGeneral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        //TODO
    }
}
