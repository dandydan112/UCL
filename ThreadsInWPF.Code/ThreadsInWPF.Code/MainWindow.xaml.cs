using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ThreadsInWPF.Code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnClean1.IsEnabled = false;
            btnClean2.IsEnabled = false;
            btnBlend1.IsEnabled = false;
            btnBlend2.IsEnabled = false;
        }

        private void BtnPutIn1_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                var fruit = (lbFruits.SelectedItem as ListBoxItem).Content;
                lbBlender1.Items.Add(new ListBoxItem { Content = fruit });
                btnClean1.IsEnabled = true;
                btnBlend1.IsEnabled = true;

            }
        }

        private void BtnPutIn2_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                var fruit = (lbFruits.SelectedItem as ListBoxItem).Content;
                lbBlender2.Items.Add(new ListBoxItem { Content = fruit });
                btnClean2.IsEnabled = true;
                btnBlend2.IsEnabled = true;

            }
        }

        private void BtnBlend1_Click(object sender, RoutedEventArgs e)
        {
            bool running1 = true;
            Thread workThread = new Thread(Blend1);
            workThread.Start();
        }

        private void BtnBlend2_Click(object sender, RoutedEventArgs e)
        {
            bool running2 = true;
            Thread workThread = new Thread(Blend2);
            workThread.Start();
        }

        private void Blend1()
        {
            pb1.Dispatcher.Invoke(new Action(() => { pb1.Value = 0; })); 
            lbBlender1.Dispatcher.Invoke(new Action(() => { btnClean1.IsEnabled = false; }));
            btnBlend1.Dispatcher.Invoke(new Action(() => { btnBlend1.IsEnabled = false; }));   
            int blendTime = 5;
            for (int i = 0; i < blendTime; i++)
            {
                if (!running1)
                {
                    break;
                }
                Thread.Sleep(1000);
                btnBlend1.Dispatcher.Invoke(new Action(() => { lblStatus1.Content = $"Blending {i}"; }));
                pb1.Dispatcher.Invoke(new Action(() => { pb1.Value = (i+1) * 20; }));
                
            }
            btnBlend1.Dispatcher.Invoke(new Action(() => { lblStatus1.Content = "Juice Ready"; }));
            btnBlend1.Dispatcher.Invoke(new Action(() => { btnBlend1.IsEnabled = true; }));
            lbBlender1.Dispatcher.Invoke(new Action(() => { btnClean1.IsEnabled = true; }));
            running1 = true;
        }

        private void Blend2()
        {
            pb2.Dispatcher.Invoke(new Action(() => { pb2.Value = 0; }));
            lbBlender1.Dispatcher.Invoke(new Action(() => { btnClean2.IsEnabled = false; }));
            btnBlend1.Dispatcher.Invoke(new Action(() => { btnBlend2.IsEnabled = false; }));
            int blendTime = 5;
            for (int i = 0; i < blendTime; i++)
            {
                if (!running2) { break; }
                Thread.Sleep(1000);
                btnBlend2.Dispatcher.Invoke(new Action(() => { lblStatus2.Content = $"Blending {i}"; }));
                pb2.Dispatcher.Invoke(new Action(() => { pb2.Value = (i+1) * 20; }));
            }
            btnBlend1.Dispatcher.Invoke(new Action(() => { lblStatus2.Content = "Juice Ready"; }));
            btnBlend1.Dispatcher.Invoke(new Action(() => { btnBlend2.IsEnabled = true; }));
            lbBlender1.Dispatcher.Invoke(new Action(() => { btnClean2.IsEnabled = true; }));
            running2 = true;
            
        }

        private void btnClean1_Click(object sender, RoutedEventArgs e)
        {
            Thread workThread = new Thread(Clear1);
            workThread.Start();
        }

        private void btnClean2_Click(object sender, RoutedEventArgs e)
        {
            Thread workThread = new Thread(Clear2);
            workThread.Start();
        }

        private void Clear1()
        {
            
            
            lbBlender1.Dispatcher.Invoke(new Action(() => { lbBlender1.Items.Clear(); }));

            lbBlender1.Dispatcher.Invoke(new Action(() => { btnClean1.IsEnabled = false; })); 

        }

        private void Clear2()
        {
            lbBlender2.Dispatcher.Invoke(new Action(() => { lbBlender2.Items.Clear(); }));

            lbBlender1.Dispatcher.Invoke(new Action(() => { btnClean2.IsEnabled = false; }));

        }

        bool running1 = true;
        bool running2 = true;
        private void btnStop1_Click(object sender, RoutedEventArgs e)
        {
            running1 = false;
        }

        private void btnStop2_Click(object sender, RoutedEventArgs e)
        {
            running2 = false;
        }
    }
}
