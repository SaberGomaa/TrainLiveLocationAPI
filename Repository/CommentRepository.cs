using Contracts;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateComment(Comment comment) =>
            Create(comment);
        public void DeleteComment(Comment comment) =>
            Delete(comment);
        public IEnumerable<Comment> GetAllComments()=>
            FindAll()
            .OrderBy(x => x.Date)
            .ToList();

        public Comment GetCommentById(int Id)=>
            FindByCondition(x => x.Id.Equals(Id)).SingleOrDefault();

        public IEnumerable<Comment> GetCommentsByPostId(int Id)=>
            FindByCondition(x=>x.PostId.Equals(Id)).OrderBy(c=>c.Date).ToList();

        public void UpdateComment(Comment comment)=>Update(comment);
    }
}
