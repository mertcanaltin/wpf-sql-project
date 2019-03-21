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

namespace ryProje02.form
{
    /// <summary>
    /// Interaction logic for ogrenciEkle.xaml
    /// </summary>
    public partial class ogrenciEkle : UserControl
    {
        public ogrenciEkle()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, RoutedEventArgs e)
        {
            if (tbOgrNo.Text != "" && tbAd.Text != "" && tbSoyad.Text != "")
            {
                ogrenciPrm veri = new ogrenciPrm();
                veri.OgrenciNo = tbOgrNo.Text;
                veri.Ad = tbAd.Text;
                veri.Soyad = tbSoyad.Text;
                veri.Bolum = tbBolum.Text;
                veri.DogumYeri = tbDogYer.Text;
                veri.BabaAd = tbBabaAdı.Text;
                if (vtIslem.veriEkleme(veri))
                {
                    ogrenciPrm.hataParam = 0;
                    ogrenciPrm.bilgiEkraniMesaj = "Kayıt İşlemi Başarılı";
                    bilgiEkrani be = new bilgiEkrani();
                    be.Show();

                    tbAd.Clear();
                    tbBabaAdı.Clear();
                    tbBolum.Clear();
                    tbDogYer.Clear();
                    tbOgrNo.Clear();
                    tbSoyad.Clear();
                    tbOgrNo.Focus();
                }
                else
                {
                    ogrenciPrm.hataParam = 1;
                    ogrenciPrm.bilgiEkraniMesaj = "Kayıt İşlemi Başarısızı oldu";
                    bilgiEkrani be = new bilgiEkrani();
                    be.Show();
                }
            }
            else
            {
                ogrenciPrm.hataParam = 1;
                ogrenciPrm.bilgiEkraniMesaj = "Alanları Boş Bırakmayınız";
                bilgiEkrani be = new bilgiEkrani();
                be.Show();
            }
           
        }
    }
}
