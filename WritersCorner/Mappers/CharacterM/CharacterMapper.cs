using System.Collections.Generic;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Models.CharacterVM;

namespace WritersCorner.Mappers.CharacterM
{
    public static class CharacterMapper
    {
        public static CharacterViewModel MapCharacter(this Character character)
        {
            if (character == null)
            {
                return null;
            }

            CharacterViewModel siteInfoVM = new CharacterViewModel
            {
                Id = character.Id,
                Name = character.Name,

                Birthday = character.Birthday,
                Death = character.Death,

                Age = character.Age,
                Gender = character.Gender,

                ImagePath = character.ImagePath,
                Nickname = character.Nickname,
                AthleticAbility = character.AthleticAbility,
                SpecialAblilty = character.SpecialAblilty,
                LanguagesSpoken = character.SpecialAblilty,

                Background = character.Background,
                Family = character.Family,
                FamilyInfo = character.FamilyInfo,
                Education = character.Education,

                EyeColor = character.EyeColor,
                FaceShape = character.FaceShape,
                FacialHair = character.FacialHair,


                HairColor = character.HairColor,
                HairTexture = character.HairTexture,


                SkinTone = character.SkinTone,
                BodyType = character.BodyType,
                Height = character.Height,
                Clothes = character.Clothes,


                Tatoos = character.Tatoos,
                Piercing = character.Piercing,
                Birthmarks = character.Birthmarks,
                Scars = character.Scars,

                Fears = character.Fears,
                Vices = character.Vices,
                Regrets = character.Regrets,
                Despise = character.Despise,

                Motivation = character.Motivation,
                Goals = character.Goals,
                AdmireOf = character.AdmireOf,

                InternalConflicts = character.InternalConflicts,
                ExternalConflicts = character.ExternalConflicts,

                Race = character.Race,
                Religion = character.Religion,
                Occupation = character.Occupation,
                MaritalStatus = character.MaritalStatus,
                Stratum = character.Stratum,

                Disabilities = character.Disabilities,
                Personality = character.Personality,
                Hobbies = character.Hobbies,
                Habits = character.Habits,
                Odds = character.Odds,
                Skills = character.Skills,
                SkillsTheyLack = character.SkillsTheyLack,
                EmotionalState = character.EmotionalState,
            };

            return siteInfoVM;
        }

        public static CharacterIndexViewModel MapFromCharacterIndex(this IEnumerable<CharacterViewModel> character,
            int currentPage, int totalPages)
        {
            var model = new CharacterIndexViewModel
            {
                Characters = character,
                CurrentPage = currentPage,
                TotalPages = totalPages,
            };

            return model;
        }
    }
}
