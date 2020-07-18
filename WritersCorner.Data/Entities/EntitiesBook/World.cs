using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    public class World : IGeneral, ICivilizationEssentials
    {
        [Key]
        public int Id { get; set; }

        #region Essential
        public string Name { get; set; }
        public string ImagePath { get; set; }
        
        public string CreationOn { get; set; }
        public string Resources { get; set; }
        public string Hierarchy { get; set; }

        public string Rulers { get; set; }

        public string Flaws { get; set; }
        public string Merits { get; set; }

        public string Size { get; set; }
        public string SituatedIn { get; set; }

        public string BargainingChip { get; set; }
        #endregion

        #region Appearance
        public string Clothes { get; set; }

        #endregion

        public string Punishments { get; set; }
        public string Characteristics { get; set; }
        public string EmotionalState { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
