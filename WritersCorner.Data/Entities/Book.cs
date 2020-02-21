using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;
using WritersCorner.Data.Entities.EntitiesBook.BookManyToMany;

namespace WritersCorner.Data.Entities
{
    public class Book : IGeneral
    {
        public Book()
        {
            this.BookCharacters = new List<BookCharacter>();
            this.BookCreatures = new List<BookCreature>();
            this.BookItems = new List<BookItem>();
            this.BookPlaces = new List<BookPlace>();
            this.BookStratums = new List<BookStratum>();
            this.BookStructures = new List<BookStructure>();
            this.BookTimelines = new List<BookTimeline>();
            this.BookWorlds = new List<BookWorld>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public ICollection<BookCharacter> BookCharacters { get; set; }
        public ICollection<BookCreature> BookCreatures { get; set; }
        public ICollection<BookItem> BookItems { get; set; }
        public ICollection<BookPlace> BookPlaces { get; set; }
        public ICollection<BookStratum> BookStratums { get; set; }
        public ICollection<BookStructure> BookStructures { get; set; }
        public ICollection<BookTimeline> BookTimelines { get; set; }
        public ICollection<BookWorld> BookWorlds { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
