using Entites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Station
    {
        [Column("StationId")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NextStation { get; set; }
        public int? NextStationPostion { get; set; }
        public string? Description { get; set; }
        public int Position { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        [ForeignKey(nameof(Railway))]
        public int? RailwayId { get; set; }
        public Railway? Railway { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }

        public ICollection<TrainInStationTime> trainInStationTimes { get; set; }

        //[ForeignKey(nameof(Train))]
        //public int TrainId { get; set; }
        //public virtual Train? Train { get; set; }

        //public ICollection<User>? Users { get; set; }
    }
}
