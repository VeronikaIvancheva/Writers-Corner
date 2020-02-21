﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WritersCorner.Data.Entities
{
    public class SiteInfo
    {
        [Key]
        public int Id { get; set; }

        public string ContactUs { get; set; }
        public string AboutUs { get; set; }
        public string FAQ { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
