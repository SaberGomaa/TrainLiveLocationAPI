using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Railway
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? StartStation { get; set; }
        public string? LastStation { get; set; }

        public ICollection<Station> Stations { get; set;}
        public ICollection<Train> Trains { get; set;}

    }
}
