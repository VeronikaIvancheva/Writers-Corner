using System;
using System.Collections.Generic;
using System.Text;

namespace WritersCorner.Data.Contracts
{
    public interface IItemEssential
    {
        public string Type { get; set; }
        public string Features { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }

        public string Rareness { get; set; }
    }
}
