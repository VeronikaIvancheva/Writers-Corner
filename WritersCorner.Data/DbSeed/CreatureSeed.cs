using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class CreatureSeed
    {
        public static void UpdateCreature(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Creature>().HasData(new Creature
            {
                Id = 1,

                Name = "Sisy",

                Location = "In house of Derm Anvil.",
                Benefits = "Help reduce the stress and calm his owner.",
                History = "",
                Gender = Enums.Gender.Female,

                ImagePath = "blackcatgreeneyes.jpg",

                Color = "Black",
                EyesColor = "Green",
                Size = "Small",
                Features = "Long whiskers and tail and pretty short legs.",
                Anathomy = "",
                Breeds = "",
                Type = "Domestic cat",
                Kind = "Cat",

                Tamed = "Yes",
                Behavior = "Mostly calm with indications of agression.",
                Interaction = "Like to play and to cuddle.",
                Aggressiveness = "low",

                EnemyOf = "Dogs and annoying people.",
                EnemyFor = "Mouse, birds",

                FriendOf = "",
                FriendFor = "People who spoil her.",

                Rareness = "Common",

                Speed = "Fast",
                Senses = "Smell, Hearing, Vision, Taste, Balance",

                Lifespan = "between 10 and 16 years",
                Health = "",

                Mythology = "no mythology for the cat in this book.",
                Superstitions = "One white hair on a black cat is good luck; Black cats protect fishermen at sea; Cats have nine lives",
                Rituals = "no rituals for the cat in this book.",
            });
        }
    }
}
