using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class FilmScheduleViewModel : BaseViewModel
    {
        private List<FilmModel> _films;

        public List<FilmModel> Films
        {
            get { return _films; }
            set { _films = value; OnPropertyChanged(nameof(Films)); }
        }

        public FilmScheduleViewModel()
        {
            _films = LoadFilmsFromCsv(@"..\..\..\..\Pr38_TheMovies.CSV");
        }



        private List<FilmModel> LoadFilmsFromCsv(string filePath)
        {
            var films = new List<FilmModel>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines.Skip(1)) // Assuming the first line is a header
            {
                // Using StringSplitOptions.None to keep empty fields as empty strings
                var columns = line.Split(new[] { '\t' }, StringSplitOptions.None);

                // Check if the columns array has the expected number of elements
                if (columns.Length < 10) // Replace 10 with the actual number of columns expected
                {
                    // Log the error or handle it as needed
                    Console.WriteLine($"Line skipped, not enough columns: {line}");
                    continue;
                }

                // It's also a good idea to add try-catch blocks around the parsing
                try
                {
                    var film = new FilmModel
                    {
                        Biograf = columns[0].Trim(),
                        By = columns[1].Trim(),
                        Forestillingstidspunkt = DateTime.ParseExact(columns[2].Trim(), "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture),
                        Filmtitel = columns[3].Trim(),
                        Filmgenre = columns[4].Trim(),
                        Filmvarighed = TimeSpan.ParseExact(columns[5].Trim(), "hh\\:mm", CultureInfo.InvariantCulture),
                        Filminstruktør = columns[6].Trim(),
                        Premieredato = DateTime.ParseExact(columns[7].Trim(), "yyyy/MM/dd", CultureInfo.InvariantCulture),
                        Bookingmail = columns[8].Trim(),
                        Bookingtelefonnummer = columns[9].Trim()
                    };
                    films.Add(film);
                }
                catch (FormatException fe)
                {
                    // Log the error or handle it as needed
                    Console.WriteLine($"Error parsing line: {line}. Error: {fe.Message}");
                }
            }

            return films;
        }



    }
}
