using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities.EntitiesBook;
using WritersCorner.Data.Entities.EntitiesBook.UserBooksItemsManyToMany;

namespace WritersCorner.Service.Contracts
{
    public interface ICharacterServices
    {
        Task<Character> GetCharacterAsync(int id);
        Task<IEnumerable<Character>> GetAllCharactersAsync(int currentPage);
        Task<IEnumerable<Character>> GetAllUserCharactersAsync(int currentPage, string userId);
        Task<IEnumerable<UserCharacter>> GetAllCharactersByUserAsync(string id);

        Task<Character> CreateCharacterAsync(Character newCharacter, string userId);
        Task<Character> EditCharacterAsync(int id);
        Task<Character> DeleteCharacterAsync(int characterId, string userId);

        Task<int> GetPageCount(int charactersPerPage);
        Task<IEnumerable<Character>> SearchCharacter(string search, int currentPage, string userId);
    }
}
