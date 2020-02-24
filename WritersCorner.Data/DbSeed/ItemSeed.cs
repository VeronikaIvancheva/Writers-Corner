using Microsoft.EntityFrameworkCore;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class ItemSeed
    {
        public static void UpdateItem(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(new Item
            {
                Id = 1,

                Name = "The one",

                Type = "Pencil",
                Features = "From tree branch",
                Material = "Wood",
                Size = "Normal - like new",

                Powers = "It never get dull, it does not decrease it's size," +
                " it can change it color or thicknes to whatever his owner wishes.",
                Rareness = "Unique",

                ImagePath = "handmadewoodenpencil.jpg",
            });
        }
    }
}
