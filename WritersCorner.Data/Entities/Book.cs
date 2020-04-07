using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Data.Entities
{
    public class Book : IGeneral
    {
        public Book()
        {
            //this.UserCharacters = new List<UserCharacter>();
            //this.UserCreatures = new List<UserCreature>();
            //this.UserItems = new List<UserItem>();
            //this.UserPlaces = new List<UserPlace>();
            //this.UserStratums = new List<UserStratum>();
            //this.UserStructures = new List<UserStructure>();
            //this.UserTimelines = new List<UserTimeline>();
            //this.UserWorlds = new List<UserWorld>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string ImagePath { get; set; }

        //public ICollection<UserCharacter> UserCharacters { get; set; }
        //public ICollection<UserCreature> UserCreatures { get; set; }
        //public ICollection<UserItem> UserItems { get; set; }
        //public ICollection<UserPlace> UserPlaces { get; set; }
        //public ICollection<UserStratum> UserStratums { get; set; }
        //public ICollection<UserStructure> UserStructures { get; set; }
        //public ICollection<UserTimeline> UserTimelines { get; set; }
        //public ICollection<UserWorld> UserWorlds { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
