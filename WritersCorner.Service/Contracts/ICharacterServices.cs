using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Service.Contracts
{
    public interface ICharacterServices
    {
        Task<Character> GetCharacterAsync(int id);
        //Task<ICollection<Character>> GetAllCharactersByUserAsync(int id);
        Task<ICollection<Character>> GetAllCharactersAsync();
        Task<Character> CreateCharacterAsync(Character newCharacter);
        //Task<Character> EditCharacterAsync(int id);
        //Task<Character> DeleteCharacterAsync(int id);
    }
}
