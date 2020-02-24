using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class StructureSeed
    {
        public static void UpdateStructure(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Structure>().HasData(new Structure
            {
                Id = 1,

                Name = "The shack",

                Type = "Wooden shack",
                Features = "Small wooden shack with one room and 2 windows and moss roof of iron",
                Material = "wood, glass and iron",
                Size = "small shack with one room and wood-house",

                Location = "In the east part of Balkan mountain",
                Rareness = "common",

                ImagePath = "woodenshack.jpg",
            });
        }
    }
}
