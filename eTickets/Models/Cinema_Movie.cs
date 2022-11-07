using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
    }
}
