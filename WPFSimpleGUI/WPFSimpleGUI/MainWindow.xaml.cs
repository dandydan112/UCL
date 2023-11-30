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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSimpleGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) { }

        private void btnScrollUp_Click(object sender, RoutedEventArgs e)
        {
            
            string pik = tbLine1.Text;
            tbLine1.Text = tbLine2.Text;
            tbLine2.Text = tbLine3.Text;
            tbLine3.Text = tbLine4.Text;
            tbLine4.Text = pik;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbLine1.Text = null;
            tbLine2.Text = null;
            tbLine3.Text = null;
            tbLine4.Text = null;
        }

        private void btnScrollDown_Click(object sender, RoutedEventArgs e)
        {
            string pik = tbLine1.Text;
            tbLine1.Text = tbLine4.Text;
            tbLine4.Text = tbLine3.Text;
            tbLine3.Text = tbLine2.Text;
            tbLine2.Text = pik;

        }
    }
}
