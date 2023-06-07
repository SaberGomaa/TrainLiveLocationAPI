using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public record LiveLocationWithoutchiledForManipulationDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
        public DateTime DateOfShareLoaction { get; set; } 

        public int TrainId { get; set; }
        public int UserId { get; set; }
    }

    public record LiveLocationDto(int Id , double Longitude , double Latitude , int TrainId , int UserId);
    public record LiveLocationDtoUpdate( double Longitude , double Latitude , int TrainId , int UserId);

    public record FilterLocationDto(double Longitude, double Latitude);
    public record LongitudeDto(double Longitude);
    public record LatitudeDto(double Latitude);

    public record LiveLocationCreationDto : LiveLocationWithoutchiledForManipulationDto;

    public record LiveLocationUpdateDto : LiveLocationWithoutchiledForManipulationDto;

}
