using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class BookingModel
    {
        public FilmModel Film { get; set; }
        public DateTime ShowTime { get; set; }
        public int SeatsAvailable { get; set; }
    }

}
