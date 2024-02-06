using Models.Models;

namespace DAL.Interfaces
{
    public interface IPhoto
    {
        Task<List<photo>> GetArrPhoto();
        Task<bool> DeletePhoto(int id);
        Task<bool> Addphoto(photo photo);
    }
}
