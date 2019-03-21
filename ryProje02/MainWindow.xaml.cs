using ryProje02.form;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ryProje02
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

        string yol;
        int secimDurumu;

        private void formBaslik_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }        

        private void btnSimge_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnBuyut_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState==WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void hamburgerMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (hamburgerMenu.Width !=40)
            {
                GridLength menuGrid = new GridLength(60, GridUnitType.Pixel);
                solMenuSutun.Width = menuGrid;
                lblBaslik.Width = 0;
                lblGuncelMenu.Visibility = Visibility.Hidden;
                lblKapatMenu.Visibility = Visibility.Hidden;
                lblListeMenu.Visibility = Visibility.Hidden;
                borderSurumBilgi.Visibility = Visibility.Hidden;
                lblYeniMenu.Visibility = Visibility.Hidden;
                hamburgerMenu.Width = 40;
            }
            else
            {
                GridLength menuGrid = new GridLength(150, GridUnitType.Pixel);
                solMenuSutun.Width = menuGrid;
                lblBaslik.Width = 120;
                lblGuncelMenu.Visibility = Visibility.Visible;
                lblKapatMenu.Visibility = Visibility.Visible;
                lblListeMenu.Visibility = Visibility.Visible;
                borderSurumBilgi.Visibility = Visibility.Visible;
                lblYeniMenu.Visibility = Visibility.Visible;
                hamburgerMenu.Width = 48;
            }
        }

        private void logoFormYukle(object sender, RoutedEventArgs e)
        {
            formCagirma.formYukleme(formGoruntuAlan, new appBackLogo());
            yol = "ses/WindowsLogon.wav";
            mixed.sesCal(yol);
        }

        private void btnYeni_Click(object sender, RoutedEventArgs e)
        {
            formCagirma.formYukleme(formGoruntuAlan, new ogrenciEkle());
            secimDurumu = 1;
        }

        private void btnListe_Click(object sender, RoutedEventArgs e)
        {
            formCagirma.formYukleme(formGoruntuAlan, new ogrenciListe());
            secimDurumu = 2;
        }        

        private void btnGuncelle_click(object sender, RoutedEventArgs e)
        {
            formCagirma.formYukleme(formGoruntuAlan, new ogrenciGuncelle());
            secimDurumu = 3;
        }

        void secilenDurumu()
        {
            if (secimDurumu == 1)
                btnYeni.IsChecked = true;
            else
                btnYeni.IsChecked = false;
            if (secimDurumu == 2)
                btnListe.IsChecked = true;
            else
                btnListe.IsChecked = false;
            if (secimDurumu == 3)
                btnGuncelle.IsChecked = true;
            else
                btnGuncelle.IsChecked = false;
        }
        
        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
