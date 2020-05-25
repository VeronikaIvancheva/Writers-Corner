using System.ComponentModel.DataAnnotations;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    //TODO
    public class Timeline
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
