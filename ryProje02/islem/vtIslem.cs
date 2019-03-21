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

namespace ryProje02
{
    public class vtIslem
    {
        static SqlConnection ogrConn;
        static SqlDataAdapter ogrAdp;
        static SqlCommand ogrCmd;
        static string sorgu;
        static sbyte kontrol;
        public static int kullanKontrol(ogrenciPrm kullanici)
        {
            int durum = 0;
            ogrConn = new SqlConnection(vtBilgi.vtAdres);
            sorgu= "SELECT COUNT (1)  FROM KULLAN WHERE kullanAd=@kullanAd AND kullanSifre=@kullanSifre";
            ogrCmd = new SqlCommand(sorgu, ogrConn);
            ogrCmd.Parameters.AddWithValue("@kullanAd", kullanici.KullanAd);
            ogrCmd.Parameters.AddWithValue("@kullanSifre", kullanici.KullanSifre);
            try
            {
                if (ogrConn.State == ConnectionState.Closed)
                    ogrConn.Open();
                durum = (int)(ogrCmd.ExecuteScalar());
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
            finally
            {
                ogrConn.Dispose();
            }
            return durum;
        }
        public static void veriDoldur(DataGrid dgData )
        {
            ogrConn = new SqlConnection(vtBilgi.vtAdres);
            sorgu = "SELECT ogrenciNo, ad, soyad, bolum, dogumYeri, babaAd FROM KIMLIK";
            DataTable ogrTablo = new DataTable();
            try
            {
                if (ogrConn.State==ConnectionState.Closed)
                    ogrConn.Open();
                ogrAdp = new SqlDataAdapter(sorgu, ogrConn);
                ogrAdp.Fill(ogrTablo);
                dgData.ItemsSource = null;
                dgData.ItemsSource = ogrTablo.DefaultView;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
            finally
            {
                //ogrConn.Dispose();
                ogrConn.Close();
            }
        }

        public static bool veriEkleme (ogrenciPrm veri)
        {
           kontrol = 0;
            ogrConn = new SqlConnection(vtBilgi.vtAdres);
            sorgu = "INSERT INTO KIMLIK (ogrenciNo, ad, soyad, bolum, dogumYeri, babaAd) " +
                "VALUES (@ogrenciNo, @ad, @soyad, @bolum, @dogumYeri, @babaAd)";
            ogrCmd = new SqlCommand(sorgu, ogrConn);
            ogrCmd.Parameters.AddWithValue("@ogrenciNo", veri.OgrenciNo);
            ogrCmd.Parameters.AddWithValue("@ad", veri.Ad);
            ogrCmd.Parameters.AddWithValue("@soyad", veri.Soyad);
            ogrCmd.Parameters.AddWithValue("@bolum", veri.Bolum);
            ogrCmd.Parameters.AddWithValue("@dogumYeri", veri.DogumYeri);
            ogrCmd.Parameters.AddWithValue("@babaAd", veri.BabaAd);
            try
            {
                if (ogrConn.State == ConnectionState.Closed)
                    ogrConn.Open();
                kontrol = (sbyte)ogrCmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
            finally
            {
                ogrConn.Dispose();
            }
            if (kontrol > 0)
                return true;
            else
                return false;
        }

        public static bool veriGuncelleme(ogrenciPrm veri)
        {
            kontrol = 0;
            ogrConn = new SqlConnection(vtBilgi.vtAdres);
            sorgu = "UPDATE KIMLIK SET ad=@ad, soyad=@soyad, bolum=@bolum, " +
                "dogumYeri=@dogumYeri, babaAd=@babaAd WHERE ogrenciNo=@ogrenciNo";
            ogrCmd = new SqlCommand(sorgu, ogrConn);
            ogrCmd.Parameters.AddWithValue("@ogrenciNo", veri.OgrenciNo);
            ogrCmd.Parameters.AddWithValue("@ad", veri.Ad);
            ogrCmd.Parameters.AddWithValue("@soyad", veri.Soyad);
            ogrCmd.Parameters.AddWithValue("@bolum", veri.Bolum);
            ogrCmd.Parameters.AddWithValue("@dogumYeri", veri.DogumYeri);
            ogrCmd.Parameters.AddWithValue("@babaAd", veri.BabaAd);
            try
            {
                if (ogrConn.State == ConnectionState.Closed)
                    ogrConn.Open();
                kontrol = (sbyte)ogrCmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
            finally
            {
                ogrConn.Dispose();
            }
            if (kontrol > 0)
                return true;
            else
                return false;
        }
        public static bool veriSilme(ogrenciPrm veri)
        {
            kontrol = 0;
            ogrConn = new SqlConnection(vtBilgi.vtAdres);
            sorgu = "DELETE FROM KIMLIK WHERE ogrenciNo=@ogrenciNo";
            ogrCmd = new SqlCommand(sorgu, ogrConn);
            ogrCmd.Parameters.AddWithValue("@ogrenciNo", veri.OgrenciNo);
           try
            {
                if (ogrConn.State == ConnectionState.Closed)
                    ogrConn.Open();
                kontrol = (sbyte)ogrCmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
            finally
            {
                ogrConn.Dispose();
            }
            if (kontrol > 0)
                return true;
            else
                return false;
        }
    }
}
