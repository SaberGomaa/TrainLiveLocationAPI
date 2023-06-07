using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record CommentWithoutchiledForManipulationDto
    {
        [Required]
        public string Content { get; set; } 
        [Required]
        public string Img { get; set; } 
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public IFormFile image { get; set; }


    }

    public record CommentDto( string? Content ,string? Img , string userName, string userPhone , int? userId, int? postId , int? adminId );
    public record ReturnedComment(int Id, string? Content, string? Img, DateTime Date , string userName, string userPhone, int? userId, int? postId);

    public record CommentCreationDto : CommentWithoutchiledForManipulationDto;

    public record CommentUpdateDto : CommentWithoutchiledForManipulationDto;
}
