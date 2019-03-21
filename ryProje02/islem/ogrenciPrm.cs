using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryProje02.islem
{
    public class ogrenciPrm
    {
        public static sbyte hataParam;
        public static string bilgiEkraniMesaj;

        private string ogrenciNo;
        private string ad;
        private string soyad;
        private string bolum;
        private string dogumYeri;
        private string babaAd;
        private string TCKimlikNo;
        private string kullanAd;
        private string kullanSifre;
        private string kullanYetki;

        public string OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Bolum { get => bolum; set => bolum = value; }
        public string DogumYeri { get => dogumYeri; set => dogumYeri = value; }
        public string BabaAd { get => babaAd; set => babaAd = value; }
        public string KullanAd { get => kullanAd; set => kullanAd = value; }
        public string KullanSifre { get => kullanSifre; set => kullanSifre = value; }
        public string KullanYetki { get => kullanYetki; set => kullanYetki = value; }
        public string TCKimlikNo1 { get => TCKimlikNo; set => TCKimlikNo = value; }
    }
}
