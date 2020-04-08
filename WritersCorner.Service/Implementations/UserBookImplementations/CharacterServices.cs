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
            this._context = context;
            this._userServices = userServices;
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

        public async Task<Character> CreateCharacterAsync(Character newCharacter)
        {
            try
            {
                await _context.Characters.AddAsync(newCharacter);
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
    }
}
