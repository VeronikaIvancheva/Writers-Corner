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

                CreationOn = null,
                Resources = "Light, air, water, plants, animals, soil, stone, minerals, and fossil fuels",
                Hierarchy = null,

                Rulers = null,

                Flaws = null,
                Merits = null,

                Size = "small",
                SituatedIn = "Solar System",

                BargainingChip = "Money, plants, animals",

                Clothes = null,

                Punishments = "prison",
                Characteristics = null,
                EmotionalState = "unstable",
            });
        }
    }
}
