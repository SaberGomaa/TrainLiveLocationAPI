using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record AdminWithoutchiledForManipulationDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string AdminDegree { get; set; } = string.Empty;
        public bool FirstTime { get; set; } = true;
        public IFormFile image { get; set; }

    }
    public record AdminDto(int Id, string? Name, string image, string? Password, string? Phone, string? Email, bool FirstTime, string? AdminDegree);

    public record AdminCreationDto : AdminWithoutchiledForManipulationDto;

    public record AdminUpdateDto : AdminWithoutchiledForManipulationDto;
}
