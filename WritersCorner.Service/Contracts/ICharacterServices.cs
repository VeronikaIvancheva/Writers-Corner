using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities.EntitiesBook;

namespace WritersCorner.Service.Contracts
{
    public interface ICharacterServices
    {
        Task<Character> GetCharacterAsync(int id);
        Task<IEnumerable<Character>> GetAllCharactersAsync(int currentPage);
        Task<IEnumerable<Character>> GetAllUserCharactersAsync(int currentPage, string userId);

        Task<Character> CreateCharacterAsync(Character newCharacter, string userId);
        Task<Character> EditCharacterAsync(Character newCharacter);
        Task<Character> DeleteCharacterAsync(int characterId, string userId);

        Task<int> GetPageCount();
        Task<IEnumerable<Character>> SearchCharacter(string search, int currentPage, string userId);
    }
}
