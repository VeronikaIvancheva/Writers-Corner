using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    public class Place : IGeneral, ICivilizationEssentials, ICivilizationEssentialsDistinguishingMarks,
        ICivilizationMilitary, ICivilizationRelationships, ICivilizationSpiritually, IWorldEssential
    {
        public Place()
        {
            this.BookPlaces = new List<BookPlace>();
        }

        [Key]
        public int Id { get; set; }

        #region Essential
        [Required]
        public string Name { get; set; }

        public string Desctiption { get; set; }
        public string History { get; set; }

        public string Travelling { get; set; }

        public string Environment { get; set; }

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

        #region Distinguishing marks
        public string Languages { get; set; }
        public string Dialects { get; set; }
        public string Asscents { get; set; }

        public string Trading { get; set; }
        public string Food { get; set; }
        public string FoodObtainingWays { get; set; }

        public string Art { get; set; }
        public string Holidays { get; set; }
        public string Entertainments { get; set; }
        #endregion

        #region Spiritually
        public string Culture { get; set; }
        public string Religion { get; set; }
        public string Cults { get; set; }
        public string Rituals { get; set; }
        #endregion

        #region Relationships with others
        public string Wars { get; set; }
        public string Unions { get; set; }

        public string Fears { get; set; }
        #endregion

        #region Military
        public string Military { get; set; }
        public string Weapons { get; set; }
        public string Training { get; set; }
        #endregion

        public string ImagePath { get; set; }

        public string Punishments { get; set; }
        public string Characteristics { get; set; }
        public string EmotionalState { get; set; }

        public ICollection<BookPlace> BookPlaces { get; set; }
    }
}
