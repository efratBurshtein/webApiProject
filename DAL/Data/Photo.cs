using Models.Models;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;
using System.Collections.Generic;

namespace DAL.Data
{
    public class Photo:IPhoto
    {
        private readonly AllContext _context;

        public Photo(AllContext context)
        {
            _context = context;
        }
       
        public async Task<List<photo>> GetArrPhoto()
        {

            List<photo> todos = await _context.Photo.ToListAsync();
            return todos;
        }
        public async Task<bool> DeletePhoto(int id)
        {
            var idPhoto = _context.Photo.FirstOrDefault(x => x.id == id);
            _context.Photo.Remove(idPhoto);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }

        public async Task<bool> Addphoto(photo photo)
        {

            await _context.Photo.AddAsync(photo);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }
        
       
    }
}
