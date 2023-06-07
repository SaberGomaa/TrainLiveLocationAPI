using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{

    public record NewsCreateDto
    {
        public string? Img { get; set; }
        public DateTime? date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "ContentOfPost is a required field.")]
        public string ContentOfPost { get; set; }

    }
    public record NewsDto(int Id, string? Img, DateTime? date, string? ContentOfPost);
    public record NewsUpdateDto : NewsCreateDto;
}