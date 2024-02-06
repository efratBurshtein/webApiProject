using Models.Models;

namespace DAL.Interfaces
{
    public interface IPost
    {
        Task<List<post>> GetArrPosts();
        Task<bool> DeletePost(int id);
        Task<bool> UpdatePost(post post);
        Task<bool> AddPost(post post);

    }
}
