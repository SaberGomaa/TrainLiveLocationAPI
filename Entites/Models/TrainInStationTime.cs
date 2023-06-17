using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
    public class TrainInStationTime
    {
        [ForeignKey(nameof(Station) )]
        public int StationId { get; set; }
        
        [ForeignKey(nameof(Train))]
        public int TrainId { get; set; }

        public Station Station { get; set; }
        public Train Train { get; set; }
        public double TrainTime { get; set; }

    }
}
