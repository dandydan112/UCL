using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TheMovies
{
    /// <summary>
    /// Interaction logic for FilmScheduleView.xaml
    /// </summary>
    public partial class FilmScheduleView : Window
    {
        public FilmScheduleView()
        {
            InitializeComponent();

            // Sætter DataContext for dette View til en ny instans af FilmScheduleViewModel
            this.DataContext = new FilmScheduleViewModel();
        }
    }
}
