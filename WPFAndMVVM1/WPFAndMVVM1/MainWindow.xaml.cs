using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAndMVVM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window/*, INotifyPropertyChanged*/
    {

        MainViewModel mvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = mvm;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            mvm.MyLabelText = DateTime.Now.ToString();
        }

        private void btnUpdate2_Click(object sender, RoutedEventArgs e)
        {
                mvm.MyTextBoxText = DateTime.Now.ToString();
        }
    }
}
