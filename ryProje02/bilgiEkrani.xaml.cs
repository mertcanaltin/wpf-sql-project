using ryProje02.islem;
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
using System.Windows.Threading;

namespace ryProje02
{
    /// <summary>
    /// Interaction logic for bilgiEkrani.xaml
    /// </summary>
    public partial class bilgiEkrani : Window
    {
        public bilgiEkrani()
        {
            InitializeComponent();
        }

        public TimeSpan Interval { get; private set; }


        private void bilgiEkrani_Loaded(object sender, RoutedEventArgs e)
        {
            var desktopWorkingArea =
                System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
            kontrol();
        }
        void kontrol()
        {
            if (ogrenciPrm.hataParam == 0)
            {
                olumluMesaj.Visibility = Visibility.Visible;
                olumsuzMesaj.Visibility = Visibility.Hidden;
                olumluResim.Visibility = Visibility.Visible;
                olumsuzResim.Visibility = Visibility.Hidden;
                bilgiEkraniIcerik.Content = ogrenciPrm.bilgiEkraniMesaj;
                mesajBaslik.Background =
                    (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF4CAF50"));
                bilgiEkraniIcerik.Foreground =
                    (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF4CAF50"));
            }
            else
            {
                olumluMesaj.Visibility = Visibility.Hidden;
                olumsuzMesaj.Visibility = Visibility.Visible;
                olumluResim.Visibility = Visibility.Hidden;
                olumsuzResim.Visibility = Visibility.Visible;
                bilgiEkraniIcerik.Content = ogrenciPrm.bilgiEkraniMesaj;
                mesajBaslik.Background =
                    (SolidColorBrush)(new BrushConverter().ConvertFrom("navy"));
                bilgiEkraniIcerik.Foreground =
                    (SolidColorBrush)(new BrushConverter().ConvertFrom("navy"));
            }

            DispatcherTimer saat = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(10)
            };

            saat.Tick += delegate (object sender, EventArgs e)
              {
                  ((DispatcherTimer)saat).Stop();
                  if (this.ShowActivated)
                      this.Close();
              };
            saat.Start();
        }

        private void bilgiEkraniKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
