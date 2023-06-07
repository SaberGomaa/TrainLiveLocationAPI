using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record PaymentWithoutchiledForManipulationDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? BankName { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [Required]
        public double Cost { get; set; }

        public DateTime? Date { get; set; }
    }

    public record PaymentDto(int id , string? bankName , int cardNumber , double cost, DateTime? Date ,int userId);

    public record PaymentCreationDto :PaymentWithoutchiledForManipulationDto;
    public record PaymentUpdateDto : PaymentWithoutchiledForManipulationDto;

}
