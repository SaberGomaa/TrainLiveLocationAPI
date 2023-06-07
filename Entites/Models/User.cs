using Entites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class User
    {
        [Column("UserId")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? img { get; set; }
        public string? Jop { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? BirthDate { get; set; }
        public string? Role { get; set; }
        public string? TokenForNotifications { get; set; }

        public ICollection<Post>? posts { get; set; }
        public ICollection<Comment>? comments { get; set; }
        public ICollection<Report>? reports { get; set; }
        public ICollection<Ticket>? tickets { get; set; }
        public ICollection<LiveLocation> liveLocations { get; set; }


        [ForeignKey(nameof(Train))]
        public int? TrainId { get; set; }
        public virtual Train? Train { get; set; }



        //[ForeignKey(nameof(Station))]
        //public int? StationId { get; set; }
        //public virtual Station? Station { get; set; }

    }
}
