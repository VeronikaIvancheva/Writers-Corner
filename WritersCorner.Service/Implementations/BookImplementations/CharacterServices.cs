using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritersCorner.Data.Context;
using WritersCorner.Data.Entities;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Service.Contracts;

namespace WritersCorner.Service.Implementations.BookImplementations
{
    public class CharacterServices : ICharacterServices
    {
        private readonly WritersCornerContext _context;

        public CharacterServices(WritersCornerContext context)
        {
            this._context = context;
        }

        public async Task<Character> GetCharacterAsync(int id)
        {
            Character character = await _context.Characters
                .FirstOrDefaultAsync(c => c.Id == id);

            return character;
        }

        //public async Task<ICollection<Character>> GetAllCharactersByUserAsync(string userId)
        //{
        //    User user = await _context.User
        //        .FirstOrDefaultAsync(u => u.Id == userId);

        //    ICollection<Character> allCharacters = await _context.Characters
        //        .Where(u => u. == userId);

        //    return allCharacters;
        //}

        public async Task<ICollection<Character>> GetAllCharactersAsync()
        {
            ICollection<Character> allCharacters = await _context.Characters
                .ToListAsync();

            return allCharacters;
        }

        public async Task<Character> CreateCharacterAsync(Character newCharacter)
        {
            await _context.Characters.AddAsync(newCharacter);
            await _context.SaveChangesAsync();

            return newCharacter;
        }

        //public async Task<Character> EditCharacterAsync(int id)
        //{
        //    Character currentCharacter = await GetCharacterAsync(id);


        //}

        //public async Task<Character> DeleteCharacterAsync(int id)
        //{

        //}
    }
}
