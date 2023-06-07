using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int Id);
        void CreatePost(Post post);
        void DeletePost(Post post);
        void UpdatePost(Post post);
    }
}
