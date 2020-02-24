using System.Collections.Generic;
using System.Threading.Tasks;
using WritersCorner.Data.Entities;

namespace WritersCorner.Service.Contracts
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> GetAllUsers(int currentPage);
        User GetUser(string id);
        User BanUser(string id, int days, string banReason, string bannedFrom);
        User RemoveBan(string id);
        Task<IEnumerable<User>> SearchUser(string search, int currentPage);
        Task<int> GetPageCount(int usersPerPage);
    }
}
