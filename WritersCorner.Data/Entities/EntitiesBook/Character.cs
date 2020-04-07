using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WritersCorner.Data.Contracts;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;
using WritersCorner.Data.Enums;

namespace WritersCorner.Data.Entities.EntitiesBook
{
    public class Character : IGeneral
    {
        public Character()
        {
            this.UserCharacters = new List<UserCharacter>();
        }

        [Key]
        public int Id { get; set; }

        #region General - essential
        [Required]
        public string Name { get; set; }

        public string Birthday { get; set; }
        public string Death { get; set; }

        public int Age { get; set; }
        public Gender Gender { get; set; }
        #endregion

        public string ImagePath { get; set; }
        public string Nickname { get; set; }
        public string AthleticAbility { get; set; }
        public string SpecialAblilty { get; set; }
        public string LanguagesSpoken { get; set; }

        #region Background
        public string Background { get; set; }
        public string Family { get; set; }
        public string FamilyInfo { get; set; }
        public string Education { get; set; }
        #endregion

        #region Appearance
        //Face
        public string EyeColor { get; set; }
        public string FaceShape { get; set; }
        public string FacialHair { get; set; }

        //Hair
        public string HairColor { get; set; }
        public string HairTexture { get; set; }

        //Body
        public string SkinTone { get; set; }
        public string BodyType { get; set; }
        public string Height { get; set; }
        public string Clothes { get; set; }

        //Body / Face
        public string Tatoos { get; set; }
        public string Piercing { get; set; }
        public string Birthmarks { get; set; }
        public string Scars { get; set; }
        #endregion

        #region Inner side
        //Negative
        public string Fears { get; set; }
        public string Vices { get; set; }
        public string Regrets { get; set; }
        public string Despise { get; set; }

        //Positive
        public string Motivation { get; set; }
        public string Goals { get; set; }
        public string AdmireOf { get; set; }

        //Conflicts
        public string InternalConflicts { get; set; }
        public string ExternalConflicts { get; set; }
        #endregion

        #region Public to people (Secret if needed)
        public string Race { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string MaritalStatus { get; set; }
        public string Stratum { get; set; }
        #endregion

        #region Personality
        public string Disabilities { get; set; }
        public string Personality { get; set; }
        public string Hobbies { get; set; }
        public string Habits { get; set; }
        public string Odds { get; set; }
        public string Skills { get; set; }
        public string SkillsTheyLack { get; set; }
        public string EmotionalState { get; set; }
        #endregion

        public ICollection<UserCharacter> UserCharacters { get; set; }
    }
}
