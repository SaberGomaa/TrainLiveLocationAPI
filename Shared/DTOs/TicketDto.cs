using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record CreateTicketDto
    {

        [Required(ErrorMessage = "TrainNumber is a required field.")]
        public string? TrainNumber { get; set; }



        [Required(ErrorMessage = "TakeOffDate is a required field.")]
        public DateTime TakeOffDate { get; set; } = DateTime.Now;


        [Required(ErrorMessage = "TakeOffStation is a required field.")]
        public string? TakeOffStation { get; set; }


        [Required(ErrorMessage = "ArrivalStation is a required field.")]
        public string? ArrivalStation { get; set; }


        [Required(ErrorMessage = "Price is a required field.")]
        public double Price { get; set; }


        [Required(ErrorMessage = "TrainDegree is a required field.")]
        public string? TrainDegree { get; set; }

        public int UserId { get; set; }
        public int TrainId { get; set; }
        public int? StationArrivalId { get; set; }

        //public int? PaymentId { get; set; }
    }

    public record TicketDto(int Id, string? TrainNumber, int? NumOfSeat, DateTime TakeOffDate, string? TakeOffStation, string? ArrivalStation, double Price, string? TrainDegree, int? UserId  , int? StationArrivalId , int TrainId);
    public record UpdateTicketDto(bool ScanedOrNot);
    public record CheckIfScannOrNotDto(int Id, bool ScanedOrNot);
}
