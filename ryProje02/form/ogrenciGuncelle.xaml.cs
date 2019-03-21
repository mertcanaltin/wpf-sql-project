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
    /// Interaction logic for ogrenciGuncelle.xaml
    /// </summary>
    public partial class ogrenciGuncelle : UserControl
    {
        public ogrenciGuncelle()
        {
            InitializeComponent();
        }

        private void ogrenciGuncelle_Loaded(object sender, RoutedEventArgs e)
        {
            vtIslem.veriDoldur(dgListe);
        }

        private void btnOgrenciGuncelle_Click(object sender, RoutedEventArgs e)
        {
            if (tbOgrNo.Text !="" && tbAd.Text !="")
            {
                ogrenciPrm veri = new ogrenciPrm();
                veri.OgrenciNo = tbOgrNo.Text;
                veri.Ad = tbAd.Text;
                veri.Soyad = tbSoyad.Text;
                veri.Bolum = tbBolum.Text;
                veri.DogumYeri= tbDogYer.Text;
                veri.BabaAd = tbBabaAdı.Text;
                if (vtIslem.veriGuncelleme(veri))
                {
                    ogrenciPrm.hataParam = 0;
                    ogrenciPrm.bilgiEkraniMesaj = "Kayıt İşlemi Başarı ile Güncellendi";
                    bilgiEkrani be = new bilgiEkrani();
                    be.Show();

                    tbOgrNo.Clear();
                    tbDogYer.Clear();
                    tbSoyad.Clear();
                    tbBolum.Clear();
                    tbBabaAdı.Clear();
                    tbAd.Clear();
                    vtIslem.veriDoldur(dgListe);
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

        private void btnOgrenciSil_Click(object sender, RoutedEventArgs e)
        {
            if (tbOgrNo.Text != "" && tbAd.Text != "")
            {
                ogrenciPrm veri = new ogrenciPrm();
                veri.OgrenciNo = tbOgrNo.Text;
                
                if (vtIslem.veriSilme(veri))
                {
                    ogrenciPrm.hataParam = 0;
                    ogrenciPrm.bilgiEkraniMesaj = "Kayıt Silme İşlemi Başarılı";
                    bilgiEkrani be = new bilgiEkrani();
                    be.Show();

                    tbOgrNo.Clear();
                    tbDogYer.Clear();
                    tbSoyad.Clear();
                    tbBolum.Clear();
                    tbBabaAdı.Clear();
                    tbAd.Clear();
                    vtIslem.veriDoldur(dgListe);
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

        private void DgListe_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            tbOgrNo.Text = ((TextBlock)dgListe.Columns[0].GetCellContent(dgListe.SelectedItem)).Text;
            tbAd.Text = ((TextBlock)dgListe.Columns[1].GetCellContent(dgListe.SelectedItem)).Text;
            tbSoyad.Text = ((TextBlock)dgListe.Columns[2].GetCellContent(dgListe.SelectedItem)).Text;
            tbBolum.Text = ((TextBlock)dgListe.Columns[3].GetCellContent(dgListe.SelectedItem)).Text;
            tbDogYer.Text = ((TextBlock)dgListe.Columns[4].GetCellContent(dgListe.SelectedItem)).Text;
            tbBabaAdı.Text = ((TextBlock)dgListe.Columns[5].GetCellContent(dgListe.SelectedItem)).Text;
        }
    }
}
