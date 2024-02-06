using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DAL.Data
{
    public class User : IUser
    {
        private readonly AllContext _context;

        public User(AllContext context)
        {
            _context = context;
        }
        public async Task<List<user>> GetArrUsers()
        {

            List<user> users = await _context.User.ToListAsync();
            return users;
        }
        public async Task<bool> DeleteUser(int id)
        {
            var idUser = _context.User.FirstOrDefault(x => x.id == id);
            _context.User.Remove(idUser);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }

        public async Task<bool> UpdateUser(user user)
        {
            var idUser = _context.User.FirstOrDefault(x => x.id == user.id);
            if (idUser == null)
            {
                return false;
            }
            idUser.phon=user.phon;
            idUser.mail=user.mail;
            idUser.address=user.address;
            idUser.name=user.name;
            var isOk = _context.SaveChanges() > 0;
            return isOk;

        }

        public async Task<bool> AddUser(user user)
        {

            await _context.User.AddAsync(user);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }
    }
}


