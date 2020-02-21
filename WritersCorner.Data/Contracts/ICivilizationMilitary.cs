using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Contracts
{
    public interface ICivilizationMilitary
    {
        public string Military { get; set; }
        public string Weapons { get; set; }
        public string Training { get; set; }
    }
}
