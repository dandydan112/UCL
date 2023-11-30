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
using static TusindfrydWPF.MainWindow;
namespace TusindfrydWPF

{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {

        public void Update()
        {

            btnOk.IsEnabled = false;

            if (txbNavn.Text != "" && txbBillede.Text != "" && txbProduktionstid.Text != "" && txbHalveringstid.Text != "" && txbStørrelse.Text != "")
            {
                btnOk.IsEnabled = true;
            }

           
        }
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            btnOk.IsEnabled = false;
            
        }

        private void txbBillede_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                BitmapImage image = new BitmapImage(new Uri(txbBillede.Text));

                imgBillede.Source = image;
            }
            catch { }



        }

        public void btnOk_Click(object sender, RoutedEventArgs e)
        {
            FlowerSort flowerSort = new FlowerSort();

            flowerSort.Name = txbNavn.Text;

            flowerSort.PicturePath = txbBillede.Text;

            int pik = Convert.ToInt32(txbProduktionstid.Text);
            flowerSort.ProductionTime = pik;

            int pik2 = Convert.ToInt32(txbHalveringstid.Text);
            flowerSort.HalfLifeTime = pik2;

            int pik3 = Convert.ToInt32(txbStørrelse.Text);
            flowerSort.Size = pik3;

            flowerSorts.Add(flowerSort);

            Close();

            Update();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void txbNavn_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void txbBillede_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void txbProduktionstid_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void txbHalveringstid_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void txbStørrelse_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
