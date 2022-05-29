
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

namespace Rozetka.UA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        private System.Windows.Threading.DispatcherTimer Timer;
        private int iter;
        public MainWindow()
        {
            InitializeComponent();
           
            DataContext = this;
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(3);
            Timer.Tick += BannerTimer_Tick;
            Timer.Start();
        }
        private void BannerTimer_Tick(object sender, EventArgs e)
        {
            iter++;
            if (iter < 7)
            {
                BannerSlider(iter);
            }
            else
            {
                iter = 1;
                BannerSlider(iter);
            }

        }

        private void BannerSlider(int n)
        {
            switch (n)
            {
                case 1:
                    rb1.IsChecked = true;
                    banner.Source = new BitmapImage(new Uri(@"/Resources/258891180.jpg", UriKind.Relative));
                    break;
                case 2:
                    rb2.IsChecked = true;
                    banner.Source = new BitmapImage(new Uri(@"/Resources/259758265.jpg", UriKind.Relative));
                    break;
                case 3:
                    rb3.IsChecked = true;
                    banner.Source = new BitmapImage(new Uri(@"/Resources/266429718.jpg", UriKind.Relative));
                    break;
                case 4:
                    rb4.IsChecked = true;
                    banner.Source = new BitmapImage(new Uri(@"/Resources/266653843.jpg", UriKind.Relative));
                    break;
                case 5:
                    rb5.IsChecked = true;
                    banner.Source = new BitmapImage(new Uri(@"/Resources/266989683.jpg", UriKind.Relative));
                    break;
                case 6:
                    rb6.IsChecked = true;
                    banner.Source = new BitmapImage(new Uri(@"/Resources/267310396.jpg", UriKind.Relative));
                    break;
            }

        }
        private void RB_Checked(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true) { banner.Source = new BitmapImage(new Uri(@"/Resources/_258891180.jpg", UriKind.Relative)); }
            else if (rb2.IsChecked == true) { banner.Source = new BitmapImage(new Uri(@"/Resources/259758265.jpg", UriKind.Relative)); }
            else if (rb3.IsChecked == true) { banner.Source = new BitmapImage(new Uri(@"/Resources/266429718.jpg", UriKind.Relative)); }
            else if (rb4.IsChecked == true) { banner.Source = new BitmapImage(new Uri(@"/Resources/266653843.jpg", UriKind.Relative)); }
            else if (rb5.IsChecked == true) { banner.Source = new BitmapImage(new Uri(@"/Resources/266989683.jpg", UriKind.Relative)); }
            else if (rb6.IsChecked == true) { banner.Source = new BitmapImage(new Uri(@"/Resources/267310396.jpg", UriKind.Relative)); }
        }
    }
}
