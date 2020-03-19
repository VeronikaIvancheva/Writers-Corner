using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities;

namespace WritersCorner.Service.Contracts
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> GetAllUsers(int currentPage);
        Task<User> GetUser(string id);
        Task<User> BanUser(string id, int days, string banReason, string bannedFrom);
        Task<User> RemoveBan(string id);
        Task<IEnumerable<User>> SearchUser(string search, int currentPage);
        Task<int> GetPageCount(int usersPerPage);
    }
}
