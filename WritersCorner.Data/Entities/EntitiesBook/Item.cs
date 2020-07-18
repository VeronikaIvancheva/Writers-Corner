using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    public class Item : IGeneral, IItemEssential
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        #region Appearance and Features
        public string Type { get; set; }
        public string Features { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        #endregion

        public string Powers { get; set; }

        public string Rareness { get; set; }

        public string ImagePath { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
