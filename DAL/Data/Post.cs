using Models.Models;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;

namespace DAL.Data
{
    public class Post:IPost
    {
        private readonly AllContext _context;

        public Post(AllContext context)
        {
            _context = context;
        }
        public async Task<List<post>> GetArrPosts()
        {

            List<post> posts = await _context.Post.ToListAsync();
            return posts;
        }
        public async Task<bool> DeletePost(int id)
        {
            var idPost = _context.Post.FirstOrDefault(x => x.id == id);
            _context.Post.Remove(idPost);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }

        public async Task<bool> UpdatePost(post post)
        {
            var idPost = _context.Post.FirstOrDefault(x => x.id == post.id);
            if (idPost == null)
            {
                return false;
            }
            idPost.contentpost = post.contentpost;
            idPost.like = post.like;
            var isOk = _context.SaveChanges() > 0;
            return isOk;

        }

        public async Task<bool> AddPost(post post)
        {

            await _context.Post.AddAsync(post);
            var isOk = _context.SaveChanges() > 0;
            return isOk;
        }
    }
}
