using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class StratumSeed
    {
        public static void UpdateStratum(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stratum>().HasData(new Stratum
            {
                Id = 1,

                Name = "",

                Desctiption = "",
                History = "",

                Travelling = "",

                Environment = "",

                CreationOn = "",
                Resources = "",
                Hierarchy = "",

                Rulers = "",

                Flaws = "",
                Merits = "",

                Size = "",
                SituatedIn = "",

                BargainingChip = "",

                Clothes = "",

                Languages = "",
                Dialects = "",
                Asscents = "",

                Trading = "",
                Food = "",
                FoodObtainingWays = "",

                Art = "",
                Holidays = "",
                Entertainments = "",

                Culture = "",
                Religion = "",
                Cults = "",
                Rituals = "",

                Wars = "",
                Unions = "",

                Fears = "",

                Military = "",
                Weapons = "",
                Training = "",

                ImagePath = "",

                Punishments = "",
                Characteristics = "",
                EmotionalState = "",
            });
        }
    }
}
