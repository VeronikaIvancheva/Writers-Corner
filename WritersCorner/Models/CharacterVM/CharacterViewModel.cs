using Microsoft.AspNetCore.Http;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Data.Enums;

namespace WritersCorner.Models.CharacterVM
{
    public class CharacterViewModel
    {
        public CharacterViewModel() { }

        public CharacterViewModel(Character character)
        {
            this.Id = character.Id;
            this.Name = character.Name;

            this.Birthday = character.Birthday;
            this.Death = character.Death;

            this.Age = character.Age;
            this.Gender = character.Gender;

            this.ImagePath = character.ImagePath;
            this.Nickname = character.Nickname;
            this.AthleticAbility = character.AthleticAbility;
            this.SpecialAblilty = character.SpecialAblilty;
            this.LanguagesSpoken = character.LanguagesSpoken;

            this.Voice = character.Voice;
            this.Trait = character.Trait;
            this.Bond = character.Bond;

            this.Background = character.Background;
            this.Family = character.Family;
            this.FamilyInfo = character.FamilyInfo;
            this.Education = character.Education;

            this.EyeColor = character.EyeColor;
            this.FaceShape = character.FaceShape;
            this.FacialHair = character.FacialHair;

            this.HairColor = character.HairColor;
            this.HairTexture = character.HairTexture;

            this.SkinTone = character.SkinTone;
            this.BodyType = character.BodyType;
            this.Height = character.Height;
            this.Clothes = character.Clothes;

            this.Tatoos = character.Tatoos;
            this.Piercing = character.Piercing;
            this.Birthmarks = character.Birthmarks;
            this.Scars = character.Scars;

            this.Fears = character.Fears;
            this.Vices = character.Vices;
            this.Regrets = character.Regrets;
            this.Despise = character.Despise;

            this.Motivation = character.Motivation;
            this.Goals = character.Goals;
            this.AdmireOf = character.AdmireOf;
            this.Ideal = character.Ideal;

            this.InternalConflicts = character.InternalConflicts;
            this.ExternalConflicts = character.ExternalConflicts;

            this.Race = character.Race;
            this.Religion = character.Religion;
            this.Occupation = character.Occupation;
            this.MaritalStatus = character.MaritalStatus;
            this.Stratum = character.Stratum;
            this.Profession = character.Profession;

            this.Disabilities = character.Disabilities;
            this.Personality = character.Personality;
            this.Hobbies = character.Hobbies;
            this.Habits = character.Habits;
            this.Odds = character.Odds;
            this.Skills = character.Skills;
            this.SkillsTheyLack = character.SkillsTheyLack;
            this.EmotionalState = character.EmotionalState;
            this.Quirk = character.Quirk;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Birthday { get; set; }
        public string Death { get; set; }

        public int Age { get; set; }
        public Gender Gender { get; set; }

        public string ImagePath { get; set; }
        public string Nickname { get; set; }
        public string AthleticAbility { get; set; }
        public string SpecialAblilty { get; set; }
        public string LanguagesSpoken { get; set; }

        public string Voice { get; set; }
        public string Trait { get; set; }
        public string Bond { get; set; } 

        public string Background { get; set; }
        public string Family { get; set; }
        public string FamilyInfo { get; set; }
        public string Education { get; set; }

        public string EyeColor { get; set; }
        public string FaceShape { get; set; }
        public string FacialHair { get; set; }

        public string HairColor { get; set; }
        public string HairTexture { get; set; }

        public string SkinTone { get; set; }
        public string BodyType { get; set; }
        public string Height { get; set; }
        public string Clothes { get; set; }

        public string Tatoos { get; set; }
        public string Piercing { get; set; }
        public string Birthmarks { get; set; }
        public string Scars { get; set; }

        public string Fears { get; set; }
        public string Vices { get; set; }
        public string Regrets { get; set; }
        public string Despise { get; set; }

        public string Motivation { get; set; }
        public string Goals { get; set; }
        public string AdmireOf { get; set; }
        public string Ideal { get; set; }

        public string InternalConflicts { get; set; }
        public string ExternalConflicts { get; set; }

        public string Race { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string MaritalStatus { get; set; }
        public string Stratum { get; set; }
        public string Profession { get; set; }

        public string Disabilities { get; set; }
        public string Personality { get; set; }
        public string Hobbies { get; set; }
        public string Habits { get; set; }
        public string Odds { get; set; }
        public string Skills { get; set; }
        public string SkillsTheyLack { get; set; }
        public string EmotionalState { get; set; }
        public string Quirk { get; set; }

        public IFormFile File { get; set; }
    }
}
