using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;

namespace WritersCorner.Data.Entities
{
    public class Book : IGeneral
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
