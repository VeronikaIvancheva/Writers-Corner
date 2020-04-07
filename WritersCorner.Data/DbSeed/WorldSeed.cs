using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class WorldSeed
    {
        public static void UpdateWorld(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<World>().HasData(new World
            {
                Id = 1,

                Name = "Earth",
                ImagePath = "world.jpg",

                CreationOn = "",
                Resources = "Light, air, water, plants, animals, soil, stone, minerals, and fossil fuels",
                Hierarchy = "",

                Rulers = "",

                Flaws = "",
                Merits = "",

                Size = "small",
                SituatedIn = "Solar System",

                BargainingChip = "Money, plants, animals",

                Clothes = "",

                Punishments = "prison",
                Characteristics = "",
                EmotionalState = "unstable",
            });
        }
    }
}
