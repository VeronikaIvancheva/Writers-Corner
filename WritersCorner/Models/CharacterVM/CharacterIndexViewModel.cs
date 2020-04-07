using System.Collections.Generic;

namespace WritersCorner.Models.CharacterVM
{
    public class CharacterIndexViewModel
    {
        public IEnumerable<CharacterViewModel> Characters { get; set; }

        public int? PreviousPage { get; set; }
        public int? NextPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
