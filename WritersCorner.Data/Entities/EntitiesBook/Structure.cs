using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    public class Structure : IGeneral, IItemEssential
    {
        public Structure()
        {
            this.BookStructures = new List<BookStructure>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        #region Appearance and Features
        public string Type { get; set; }
        public string Features { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        #endregion

        public string Location { get; set; }

        public string Rareness { get; set; }

        public string ImagePath { get; set; }

        public ICollection<BookStructure> BookStructures { get; set; }
    }
}
