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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();

            
           

        }

        private void btnOpretBlomstersort_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog flowerDialog = new CreateFlowerSortDialog();
            flowerDialog.ShowDialog();
            
        }

        public void Update()
        {

            lstbxBlomstyersorter.Text = "";

            foreach (FlowerSort sort in flowerSorts)
            {
                lstbxBlomstyersorter.Text += ("Navn: " + sort.Name + "\n" + "Sti: " + sort.PicturePath + "\n" + "Produktionstid: " + sort.ProductionTime + "\n" + "Halveringstid" + sort.HalfLifeTime + "\n" + "Størrelse: " + sort.Size + "\n");
            }


        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
