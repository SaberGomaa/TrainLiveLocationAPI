using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePost(Post post)=>
            Create(post);
        public void DeletePost(Post post)=>
            Delete(post);

        public IEnumerable<Post> GetAllPosts()=>
            FindAll()
            .OrderBy(x=>x.Id)
            .ToList();
        public Post GetPostById(int Id) =>
            FindByCondition(c => c.Id.Equals(Id)).SingleOrDefault();

        public void UpdatePost(Post post)=>
            Update(post);
    }
}
