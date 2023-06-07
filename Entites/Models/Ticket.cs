using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? TrainNumber { get; set; }
        public int NumOfSeat { get; set; }
        public DateTime TakeOffDate { get; set; }
        public string? TakeOffStation { get; set; }
        public string? ArrivalStation { get; set; }
        public double Price { get; set; }
        public bool ScanedOrNot { get; set; }
        public string? TrainDegree { get; set; }
        public string? UserJop { get; set; }
        public string? UserName { get; set;}
        public string? UserToken { get; set; }
        public string? UserPhone { get; set; }

        public string? UserEmail { get; set; }

        ///////////
        
        [ForeignKey(nameof(StationArrival))]
        public int? StationArrivalId { get; set; }
        public virtual Station? StationArrival { get; set; }

        //[ForeignKey(nameof(StationTakeOff))]
        //public int? StationTakeOffId { get; set; }
        //public virtual Station? StationTakeOff { get; set; }

        /////////

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey(nameof(Train))]
        public int TrainId { get; set; }
        public virtual Train? Train { get; set; }

        //[ForeignKey(nameof(payment))]
        //public int PaymentId { get; set; }
        //public virtual Payment? payment { get; set; }


    }
}
