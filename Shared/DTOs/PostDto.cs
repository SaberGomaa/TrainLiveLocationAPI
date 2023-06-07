using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record PostWithoutchiledForManipulationDto
    {
  
        [Required]
        public string Content { get; set; }
        [Required]
        public int TrainNumber { get; set; }
        [Required]
        public bool Critical { get; set; }
        public string? Img { get; set; }
        public string ImgId { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
         public string UserName { get; set; }
        public string UserPhone { get; set; } 
        public int? AdminId { get; set; }
        public int UserId { get; set; }
        public IFormFile image { get; set; }


    }

    public record PostDto(int Id , string Content , int TrainNumber , bool Critical  , string? Img, int UserId, string UserPhone, DateTime Date, int? AdminId, string UserName, string imgId);

    public record PostCreationDto : PostWithoutchiledForManipulationDto;
    public record PostUpdateDto : PostWithoutchiledForManipulationDto;
}
