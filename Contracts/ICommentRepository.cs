using Entites;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllComments();
        Comment GetCommentById(int Id);
        IEnumerable<Comment> GetCommentsByPostId(int Id);
        void CreateComment(Comment comment);
        void DeleteComment(Comment comment);
        void UpdateComment(Comment comment);
    }
}
