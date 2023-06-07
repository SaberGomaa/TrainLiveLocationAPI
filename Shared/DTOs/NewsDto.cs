using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs
{
    public record NewsCreateDto
    {
        [Required(ErrorMessage = "ContentOfPost is a required field.")]
        public string ContentOfPost { get; set; }
        public IFormFile image { get; set; } 
    }

    public record NewsDto(int Id, string Img, DateTime? date, string? ContentOfPost);
    public record NewsUpdateDto : NewsCreateDto;
}