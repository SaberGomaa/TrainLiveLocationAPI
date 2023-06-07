using Entites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Admin
    {
        [Column("AdminId")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? AdminDegree { get; set; }
        public bool FirstTime { get; set; } = true;
        public ICollection<News>? News { get; set; }

        public ICollection<Comment>? comments { get; set; }
        public ICollection<Post>? posts { get; set; }

    }
}
