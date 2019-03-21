using ryProje02.islem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ryProje02.form
{
    /// <summary>
    /// Interaction logic for giris.xaml
    /// </summary>
    public partial class giris : Window
    {
        public giris()
        {
            InitializeComponent();
        }

        public ConnectionState Connection { get; private set; }

        private void btnGiris_Click(object sender, RoutedEventArgs e)
        {
            if (tbKullanAd.Text !="" && tbSifre.Password !="")
            {
                ogrenciPrm veri = new ogrenciPrm();
                veri.KullanAd = tbKullanAd.Text;
                veri.KullanSifre = tbSifre.Password;
                int durum = vtIslem.kullanKontrol(veri);
                if (durum==1)
                {
                    MainWindow anaform = new MainWindow();
                    anaform.lblKullanAd.Content = tbKullanAd.Text;
                    anaform.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifresi", "Bilgi", 
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }                
        }
    }
}
