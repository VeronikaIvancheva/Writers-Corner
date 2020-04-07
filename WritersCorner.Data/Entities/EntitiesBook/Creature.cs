using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;
using WritersCorner.Data.Enums;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    public class Creature : IGeneral
    {
        public Creature()
        {
            this.UserCreatures = new List<UserCreature>();
        }

        [Key]
        public int Id { get; set; }

        #region Essentials
        [Required]
        public string Name { get; set; }

        public string Location { get; set; }
        public string Benefits { get; set; }
        public string History { get; set; }
        public Gender Gender { get; set; }
        #endregion

        public string ImagePath { get; set; }

        #region Appearance and Features
        public string Color { get; set; }
        public string EyesColor { get; set; }
        public string Size { get; set; }
        public string Features { get; set; }
        public string Anathomy { get; set; }
        public string Breeds { get; set; }
        public string Type { get; set; }
        public string Kind { get; set; }
        #endregion

        #region Behavior towards/with other
        public string Tamed { get; set; }
        public string Behavior { get; set; }
        public string Interaction { get; set; }
        public string Aggressiveness { get; set; }

        public string EnemyOf { get; set; }
        public string EnemyFor { get; set; }

        public string FriendOf { get; set; }
        public string FriendFor { get; set; }
        #endregion

        public string Rareness { get; set; }

        public string Speed { get; set; }
        public string Senses { get; set; }

        public string Lifespan { get; set; }
        public string Health { get; set; }

        public string Mythology { get; set; }
        public string Superstitions { get; set; }
        public string Rituals { get; set; }

        public ICollection<UserCreature> UserCreatures { get; set; }
    }
}
