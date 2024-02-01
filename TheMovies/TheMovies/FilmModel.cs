using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class FilmModel
    {
        public string Biograf { get; set; }
        public string By { get; set; }
        public DateTime Forestillingstidspunkt { get; set; }
        public string Filmtitel { get; set; }
        public string Filmgenre { get; set; }
        public TimeSpan Filmvarighed { get; set; }
        public string Filminstruktør { get; set; }
        public DateTime Premieredato { get; set; }
        public string Bookingmail { get; set; }
        public string Bookingtelefonnummer { get; set; }
    }


}
