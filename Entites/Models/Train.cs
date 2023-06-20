using Entites.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites
{
    public class Train
    {
        [Column("TrainId")]
        public int Id { get; set; }
        public string? Degree { get; set; }
        public string? TrainNumber { get; set; }
        public int NumOfSeat { get; set; }
        public double TrainTime { get; set; }
        public int NumOfTrainCars { get; set; }
        //////
        public string? Conductor { get; set; }
        public string? Driver { get; set; }
        ///////
        public string? CurrentLocation { get; set; }


        [ForeignKey(nameof(Railway))]
        public int? RailwayId { get; set; }
        public Railway? Railway { get; set; }

        public ICollection<TrainInStationTime> trainInStationTimes { get; set; }
        public ICollection<LiveLocation> liveLocations { get; set; }
        public ICollection<User>?users { get; set; }
        //public ICollection <Station>?stations { get; set; }
        public ICollection <Ticket>?tickets { get; set; }

    }
}
