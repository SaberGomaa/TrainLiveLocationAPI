using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs
{

    public record UserForManipulationDto
    {
        [Required(ErrorMessage = "user name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string? Name { get; init; }
        [EmailAddress]
        [Required(ErrorMessage = "Email is a required field.")]
        public string? Email { get; init; }


        [Phone]
        [Required(ErrorMessage = "Phone is a required field.")]
        public string? Phone { get; init; }

        [Required(ErrorMessage = "Password a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Password is 30 characters.")]
        public string? Password { get; init; }

        [Required(ErrorMessage = "Jop is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Jop is 30 characters.")]
        public string? Jop { get; init; }

        [Required(ErrorMessage = "Address is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Adress is 30 characters.")]
        public string? Address { get; init; }

        [Required(ErrorMessage = "Gender is a required field.")]
        public string? Gender { get; init; }

        [Required(ErrorMessage = "BirthDate is a required field.")]
        public string? BirthDate { get; init; }

        [Required(ErrorMessage = "Role is a required field.")]
        public string? Role { get; init; }
        public string? TokenForNotifications { get; set; }
        //public IFormFile image { get; set; }

    }

    public record userDto(int Id, string Name, string Email, string Phone, string Password, string Jop, string Address, string Gender, string BirthDate, string? TokenForNotifications, string Role);
    public record userloginDTO(string Name);
    public record userTokenDTO(int Id , string TokenForNotifications);
    public record DoctorDTO(int Id, string Name, string Email, string Phone);
    public record UserCreationDto : UserForManipulationDto;
    public record UserUpdateDto : UserForManipulationDto;
}

