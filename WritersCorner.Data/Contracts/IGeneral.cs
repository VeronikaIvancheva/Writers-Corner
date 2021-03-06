﻿using WritersCorner.Data.Entities;

namespace WritersCorner.Data.Contracts
{
    public interface IGeneral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
