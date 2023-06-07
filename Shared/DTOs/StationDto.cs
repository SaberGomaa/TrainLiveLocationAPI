﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
   public record StationForManubalitaion
    {
        [Required(ErrorMessage = "Station name is a required field.")]
        public string? Name { get; init; }
        [Required(ErrorMessage = "NextStation is a required field.")]
        public string? NextStation { get; init; }
        [Required(ErrorMessage = "Description is a required field.")]
        public string? Description { get; init; }
        public int Position { get; set; }

        [Required(ErrorMessage = "TrainId is a required field.")]
        [Range(0,10000)]
        public int TrainId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

    public record StationDto(int Id, string? Name, string? NextStation,int Position, string? Description, int TrainId, double Longitude, double Latitude);
    public record StatioForOneTrainDto(int Id, string? Name, string? NextStation, int Position, string? Description, int TrainId, double Longitude, double Latitude);
    public record StationForUpdateDto: StationForManubalitaion;
    public record StationForCreateDto : StationForManubalitaion;
}
