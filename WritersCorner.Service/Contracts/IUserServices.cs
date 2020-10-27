using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities;

namespace WritersCorner.Service.Contracts
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> GetAllUsersAsync(int currentPage);
        Task<User> GetUserAsync(string id);
        Task<User> BanUserAsync(string id, int days, string banReason, string bannedFrom);
        Task<User> RemoveBanAsync(string id);
        Task<IEnumerable<User>> SearchUserAsync(string search, int currentPage);
        Task<int> GetPageCountAsync();
    }
}
