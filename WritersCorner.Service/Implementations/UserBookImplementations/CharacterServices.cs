using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WritersCorner.Data.Context;
using WritersCorner.Data.Entities;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Service.Contracts;
using WritersCorner.Service.CustomException;

namespace WritersCorner.Service.Implementations.UserBookImplementations
{
    public class CharacterServices : ICharacterServices
    {
        private readonly WritersCornerContext _context;

        public CharacterServices(WritersCornerContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Character> GetCharacterAsync(int id)
        {
            Character character = await _context.Characters
                .FirstOrDefaultAsync(c => c.Id == id);

            return character;
        }

        public async Task<IEnumerable<Character>> GetAllCharactersAsync(int currentPage)
        {
            try
            {
                IEnumerable<Character> allUserCharacters = await _context.Characters
                    .ToListAsync();

                IEnumerable<Character> allCharacters = null;

                foreach (var item in allUserCharacters)
                {
                    allCharacters = await _context.Characters
                         .OrderBy(u => u.Name)
                         .ToListAsync();
                }

                if (currentPage == 1)
                {
                    allCharacters = allCharacters
                         .Take(10);
                }
                else
                {
                    allCharacters = allCharacters
                        .Skip((currentPage - 1) * 10)
                        .Take(10);
                }

                return allCharacters;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.NoCharacters);
            }
        }

        public async Task<IEnumerable<Character>> GetAllUserCharactersAsync(int currentPage, string userId)
        {
            try
            {
                IEnumerable<Character> allUserCharacters = await _context.Characters
                    .Where(u => u.UserId == userId)
                    .ToListAsync();

                IEnumerable<Character> allCharacters;

                foreach (var item in allUserCharacters)
                {
                    allCharacters = _context.Characters
                        .Where(u => u.Id == item.Id);
                }

                if (currentPage == 1)
                {
                    allCharacters = allUserCharacters
                         .Take(10)
                         .ToList();
                }
                else
                {
                    allCharacters = allUserCharacters
                        .Skip((currentPage - 1) * 10)
                        .Take(10)
                        .ToList();
                }

                return allCharacters;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.NoCharacters);
            }
        }

        public async Task<Character> CreateCharacterAsync(Character newCharacter, string userId)
        {
            try
            {
                Character character = PassCharacterParams(newCharacter, userId);

                await _context.Characters.AddAsync(character);
                await _context.SaveChangesAsync();

                return newCharacter;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<Character> EditCharacterAsync(Character newCharacter)
        {
            Character currentCharacter = await GetCharacterAsync(newCharacter.Id);

            try
            {
                _context.Entry(currentCharacter).CurrentValues.SetValues(newCharacter);
                await _context.SaveChangesAsync();

                return newCharacter;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<Character> DeleteCharacterAsync(int characterId, string userId)
        {
            Character characterForRemove = await GetCharacterAsync(characterId);

            if (characterForRemove == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoDelete);
            }

            try
            {
                _context.Characters.Remove(characterForRemove);
                await _context.SaveChangesAsync();

                return characterForRemove;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<IEnumerable<Character>> SearchCharacter(string search, int currentPage, string userId)
        {
            try
            {
                User currentUserId = await _context.User
                    .FirstOrDefaultAsync(u => u.Id == userId);

                IEnumerable<Character> searchResult = await _context.Characters
                    .Where(
                           b => b.Name.Contains(search) ||
                           b.Nickname.Contains(search) ||
                           b.Race.Contains(search) ||
                           b.Stratum.Contains(search) ||
                           b.Gender.ToString().ToLower().Contains(search.ToLower())
                           )
                    .OrderByDescending(b => b.Name)
                    .ToListAsync();

                if (currentPage == 1)
                {
                    searchResult = searchResult
                    .Take(10);
                }
                else
                {
                    searchResult = searchResult
                    .Skip((currentPage - 1) * 10)
                    .Take(10);
                }

                return searchResult;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<int> GetPageCount(int charactersPerPage)
        {
            var allCharacters = await _context.Characters
                .CountAsync();

            var totalPages = (allCharacters - 1) / charactersPerPage + 1;

            return totalPages;
        }

        public Character PassCharacterParams(Character viewModel, string userId)
        {
            var newCharacter = new Character
            {
                Name = viewModel.Name,

                Birthday = viewModel.Birthday,
                Death = viewModel.Death,

                Age = viewModel.Age,
                Gender = viewModel.Gender,

                ImagePath = viewModel.ImagePath,
                Nickname = viewModel.Nickname,
                AthleticAbility = viewModel.AthleticAbility,
                SpecialAblilty = viewModel.SpecialAblilty,
                LanguagesSpoken = viewModel.LanguagesSpoken,

                Trait = viewModel.Trait,
                Voice = viewModel.Voice,
                Bond = viewModel.Bond,

                Background = viewModel.Background,
                Family = viewModel.Family,
                FamilyInfo = viewModel.FamilyInfo,
                Education = viewModel.Education,

                EyeColor = viewModel.EyeColor,
                FaceShape = viewModel.FaceShape,
                FacialHair = viewModel.FacialHair,

                HairColor = viewModel.HairColor,
                HairTexture = viewModel.HairTexture,

                SkinTone = viewModel.SkinTone,
                BodyType = viewModel.BodyType,
                Height = viewModel.Height,
                Clothes = viewModel.Clothes,

                Tatoos = viewModel.Tatoos,
                Piercing = viewModel.Piercing,
                Birthmarks = viewModel.Birthmarks,
                Scars = viewModel.Scars,

                Fears = viewModel.Fears,
                Vices = viewModel.Vices,
                Regrets = viewModel.Regrets,
                Despise = viewModel.Despise,

                Motivation = viewModel.Motivation,
                Goals = viewModel.Goals,
                AdmireOf = viewModel.AdmireOf,

                InternalConflicts = viewModel.InternalConflicts,
                ExternalConflicts = viewModel.ExternalConflicts,

                Ideal = viewModel.Ideal,

                Race = viewModel.Race,
                Religion = viewModel.Religion,
                Occupation = viewModel.Occupation,
                MaritalStatus = viewModel.MaritalStatus,
                Stratum = viewModel.Stratum,
                Profession = viewModel.Profession,

                Disabilities = viewModel.Disabilities,
                Personality = viewModel.Personality,
                Hobbies = viewModel.Hobbies,
                Habits = viewModel.Habits,
                Odds = viewModel.Odds,
                Skills = viewModel.Skills,
                SkillsTheyLack = viewModel.SkillsTheyLack,
                EmotionalState = viewModel.EmotionalState,
                Quirk = viewModel.Quirk,

                UserId = userId
            };

            return newCharacter;
        }

        //public Character CheckIfNull(Character character)
        //{
        //    var check = new List<Character>() { character };

        //    for (int i = 0; i < check.Count - 1; i++)
        //    {
        //        if (check[i] == null)
        //        {
        //            check[i] = "none";
        //        }
        //    }

        //    return character;
        //}
    }
}
