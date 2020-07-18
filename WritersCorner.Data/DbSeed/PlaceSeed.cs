using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class PlaceSeed
    {
        public static void UpdatePlace(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>().HasData(new Place
            {
                Id = 1,

                Name = "The easten forest",

                Desctiption = "Forest from tall oak trees that is uninhabitable from other people",
                History = "No one know how old is the forest but there are rumors that it is there even before the humanknid",

                Travelling = "on foot",

                Environment = "Oak trees",

                CreationOn = "Unknown",
                Resources = "wood, forest fruits",
                Hierarchy = "Unknown",

                Rulers = "Executive Forest Agency",

                Flaws = "not enough food and materials for normal life",
                Merits = "quiet with clean air and nature all over the place",

                Size = "extremely big",
                SituatedIn = "Balkan mountain - Bulgaria",

                BargainingChip = "none",

                Clothes = "wathever you buy or make",

                Languages = "wathever language you speak but mostly bulgarian",
                Dialects = "",
                Asscents = "english",

                Trading = "none",
                Food = "forest berries, birds eggs, insects, animals ad fish",
                FoodObtainingWays = "hunting or collecting",

                Art = "the art of nature",
                Holidays = "none",
                Entertainments = "walk in the woods, hunting, burd singing, fishing",


                Culture = "none",
                Religion = "none",
                Cults = "",
                Rituals = "",

                Wars = "with the rest of humanity that wishes to destroy the place",
                Unions = "",

                Fears = "bears and wolves",

                Military = "none",
                Weapons = "wooden swords, spikes and cookwares",
                Training = "running",


                ImagePath = "balkanmountains.jpg",

                Punishments = "",
                Characteristics = "beautiful and peaceful",
                EmotionalState = "peaceful",

                UserId = "1"
            });
        }
    }
}
