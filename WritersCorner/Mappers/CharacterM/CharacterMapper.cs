using System.Collections.Generic;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Models.CharacterVM;

namespace WritersCorner.Mappers.CharacterM
{
    public static class CharacterMapper
    {
        #region Map from Data
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
                LanguagesSpoken = character.LanguagesSpoken,

                Bond = character.Bond,
                Voice = character.Voice,
                Trait = character.Trait,

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
                Ideal = character.Ideal,

                Race = character.Race,
                Religion = character.Religion,
                Occupation = character.Occupation,
                MaritalStatus = character.MaritalStatus,
                Stratum = character.Stratum,
                Profession = character.Profession,

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
        #endregion

        #region Map from view model
        public static Character MapCharacter(this CharacterViewModel characterVM)
        {
            if (characterVM == null)
            {
                return null;
            }

            Character siteInfoVM = new Character
            {
                Id = characterVM.Id,
                Name = characterVM.Name,

                Birthday = characterVM.Birthday,
                Death = characterVM.Death,

                Age = characterVM.Age,
                Gender = characterVM.Gender,

                ImagePath = characterVM.ImagePath,
                Nickname = characterVM.Nickname,
                AthleticAbility = characterVM.AthleticAbility,
                SpecialAblilty = characterVM.SpecialAblilty,
                LanguagesSpoken = characterVM.LanguagesSpoken,

                Bond = characterVM.Bond,
                Voice = characterVM.Voice,
                Trait = characterVM.Trait,

                Background = characterVM.Background,
                Family = characterVM.Family,
                FamilyInfo = characterVM.FamilyInfo,
                Education = characterVM.Education,

                EyeColor = characterVM.EyeColor,
                FaceShape = characterVM.FaceShape,
                FacialHair = characterVM.FacialHair,

                HairColor = characterVM.HairColor,
                HairTexture = characterVM.HairTexture,

                SkinTone = characterVM.SkinTone,
                BodyType = characterVM.BodyType,
                Height = characterVM.Height,
                Clothes = characterVM.Clothes,

                Tatoos = characterVM.Tatoos,
                Piercing = characterVM.Piercing,
                Birthmarks = characterVM.Birthmarks,
                Scars = characterVM.Scars,

                Fears = characterVM.Fears,
                Vices = characterVM.Vices,
                Regrets = characterVM.Regrets,
                Despise = characterVM.Despise,

                Motivation = characterVM.Motivation,
                Goals = characterVM.Goals,
                AdmireOf = characterVM.AdmireOf,

                InternalConflicts = characterVM.InternalConflicts,
                ExternalConflicts = characterVM.ExternalConflicts,
                Ideal = characterVM.Ideal,

                Race = characterVM.Race,
                Religion = characterVM.Religion,
                Occupation = characterVM.Occupation,
                MaritalStatus = characterVM.MaritalStatus,
                Stratum = characterVM.Stratum,
                Profession = characterVM.Profession,

                Disabilities = characterVM.Disabilities,
                Personality = characterVM.Personality,
                Hobbies = characterVM.Hobbies,
                Habits = characterVM.Habits,
                Odds = characterVM.Odds,
                Skills = characterVM.Skills,
                SkillsTheyLack = characterVM.SkillsTheyLack,
                EmotionalState = characterVM.EmotionalState,
            };

            return siteInfoVM;
        }
        #endregion

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
