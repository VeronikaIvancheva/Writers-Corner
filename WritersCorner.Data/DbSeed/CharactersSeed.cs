using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WritersCorner.Data.Entities;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Data.DbSeed
{
    public static class CharactersSeed
    {
        public static void UpdateCharacter(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 1,
                Name = "Derm Anvil",

                Birthday = "14 may 2004",
                Death = "",

                Age = 17,
                Gender = Enums.Gender.Male,
                ImagePath = "graycharacter.jpg",
                Nickname = "",
                AthleticAbility = "Poor",
                SpecialAblilty = "Can make unique magical wood items",
                LanguagesSpoken = "English, Spanish",
                Voice = "Quiet and calm",
                Trait = "Don't like to engage others in conversation",
                Bond = "Bond with nature - can feel it's pain",

                Background = "Very closed in most of his life. After his parents die he went in Bulgaria" +
                " to live the rest of his life in isolated cabin in the woods",
                Family = "Mia Anvil, Pether Anvil",
                FamilyInfo = "They lived and die in England. The mother was born in Spain and lived there till she met" +
                " Pether and fall in love with him",
                Education = "Secondary",

                EyeColor = "Green",
                FaceShape = "Oval",
                FacialHair = "no",

                HairColor = "Gray",
                HairTexture = "",

                SkinTone = "White",
                BodyType = "Thin, Muscular",
                Height = "175 sm",
                Clothes = "prefer: t-shirt and jeans",

                Tatoos = "no",
                Piercing = "no",
                Birthmarks = "no",
                Scars = "no",

                Fears = "afraid to be left behind again",
                Vices = "too obsessive",
                Regrets = "that he let her go",
                Despise = "",

                Motivation = "her smile",
                Goals = "to make a real live wooden doll that look exactly like her",
                AdmireOf = "her everything",

                InternalConflicts = "",
                ExternalConflicts = "",
                Ideal = "His master and teacher Ramir",

                Race = "Human",
                Religion = "Christian",
                Occupation = "Bulgaria - in the woods of Balkan mountain",
                MaritalStatus = "Single",
                Stratum = "Middle class",
                Profession = "Woodcrafter",

                Disabilities = "to be more insistent",
                Personality = "Indecisive",
                Hobbies = "Woodcarving",
                Habits = "to make non-magical items",
                Odds = "His left eye change it's color to blue when night",
                Skills = "Woodcrafting",
                SkillsTheyLack = "He is shy so have problems with communication. Can't swim",
                EmotionalState = "Stable - he have no problem with it when there is someone around",
                Quirk = "Can spend time alone for weeks without that to bother him", 

                UserId = "1"
            });
        }
    }
}
