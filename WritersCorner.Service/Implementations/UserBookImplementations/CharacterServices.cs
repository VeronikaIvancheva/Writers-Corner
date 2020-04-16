using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritersCorner.Data.Context;
using WritersCorner.Data.Entities;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;
using WritersCorner.Service.Contracts;
using WritersCorner.Service.CustomException;

namespace WritersCorner.Service.Implementations.UserBookImplementations
{
    public class CharacterServices : ICharacterServices
    {
        private readonly WritersCornerContext _context;
        private readonly IUserServices _userServices;

        public CharacterServices(WritersCornerContext context, IUserServices userServices)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
            this._userServices = userServices ?? throw new ArgumentNullException(nameof(userServices));
        }

        public async Task<Character> GetCharacterAsync(int id)
        {
            Character character = await _context.Characters
                .FirstOrDefaultAsync(c => c.Id == id);

            return character;
        }

        public async Task<IEnumerable<UserCharacter>> GetAllCharactersByUserAsync(string userId)
        {
            try
            {
                IEnumerable<UserCharacter> allUserCharacters = await _context.UserCharacters
                    .Where(u => u.UserId == userId)
                    .ToListAsync();

                return allUserCharacters;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.NoCharacters);
            }
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
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.NoCharacters);
            }
        }

        public async Task<IEnumerable<Character>> GetAllUserCharactersAsync(int currentPage, string userId)
        {
            try
            {
                //User currUser = await _userServices.GetUserAsync(userId);
                //IEnumerable<UserCharacter> userCharacters = await _context.UserCharacters
                //    .Where(u => u.UserId == userId)
                //    .ToListAsync();

                IEnumerable<UserCharacter> userCharacters = await GetAllCharactersByUserAsync(userId);

                IEnumerable<Character> allCharacters = null;

                foreach (var item in userCharacters)
                {
                    allCharacters = await _context.Characters
                         .Where(u => u.Id == item.CharacterId)
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
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.NoCharacters);
            }
        }

        public async Task<Character> CreateCharacterAsync(Character newCharacter, string userId)
        {
            try
            {
                //Character character = CheckIfNull(newCharacter);
                Character character = PassCharacterParams(newCharacter);

                await _context.Characters.AddAsync(character);
                await _context.SaveChangesAsync();

                User user = await _userServices.GetUserAsync(userId);
                UserCharacter userCharacter = PassUserCharacterParams(character, user);

                await _context.UserCharacters.AddAsync(userCharacter);
                await _context.SaveChangesAsync();

                return newCharacter;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<Character> EditCharacterAsync(int id)
        {
            Character currentCharacter = await GetCharacterAsync(id);

            if (currentCharacter == null)
            {
                throw new Exception(ExceptionMessage.NoEdit);
            }

            try
            {
                return currentCharacter;
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<Character> DeleteCharacterAsync(int characterId, string userId)
        {
            User user = await _userServices.GetUserAsync(userId);
            Character character = await GetCharacterAsync(characterId);

            if (character == null)
            {
                throw new Exception(ExceptionMessage.NoDelete);
            }

            try
            {
                return character;
            }
            catch (Exception)
            {

                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<IEnumerable<Character>> SearchCharacter(string search, int currentPage, string userId)
        {
            try
            {
                UserCharacter currentUserId = await _context.UserCharacters
                    .FirstOrDefaultAsync(u => u.UserId == userId);

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
            catch (Exception)
            {
                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<int> GetPageCount(int charactersPerPage)
        {
            var allCharacters = await _context.Characters
                .CountAsync();

            var totalPages = (allCharacters - 1) / charactersPerPage + 1;

            return totalPages;
        }

        public Character PassCharacterParams(Character viewModel)
        {
            var newCharacter = new Character
            {
                Name = viewModel.Name,

                Birthday = viewModel.Birthday,
                Death = viewModel.Death,

                Age = viewModel.Age,
                Gender = viewModel.Gender,

                ImagePath= viewModel.ImagePath,
                Nickname = viewModel.Nickname,
                AthleticAbility = viewModel.AthleticAbility,
                SpecialAblilty = viewModel.SpecialAblilty,

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

                Race = viewModel.Race,
                Religion = viewModel.Religion,
                Occupation = viewModel.Occupation,
                MaritalStatus = viewModel.MaritalStatus,
                Stratum = viewModel.Stratum,

                Disabilities = viewModel.Disabilities,
                Personality = viewModel.Personality,
                Hobbies = viewModel.Hobbies,
                Habits = viewModel.Habits,
                Odds = viewModel.Odds,
                Skills = viewModel.Skills,
                SkillsTheyLack = viewModel.SkillsTheyLack,
                EmotionalState = viewModel.EmotionalState
            };

            return newCharacter;
        }

        public UserCharacter PassUserCharacterParams(Character character, User user)
        {
            var newUserCharacter = new UserCharacter
            {
                User = user,
                UserId = user.Id,

                Character = character,
                CharacterId = character.Id,
            };

            return newUserCharacter;
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
