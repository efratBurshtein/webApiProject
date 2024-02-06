using Models.Models;

namespace DAL.Data
{
    public interface IUser
    {
        Task<List<user>> GetArrUsers();
        Task<bool> DeleteUser(int id);
        Task<bool> UpdateUser(user user);
        Task<bool> AddUser(user user);
    }
}
   

