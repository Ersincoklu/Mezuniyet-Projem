using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UrunIslemleri:DataConnection
    {
        public int UrunEkle(int tip, int tur, int kategori, int urunKodu, string urunAd, string urunOzeti, decimal urunAlisFiyati, decimal urunSatisFiyati, int urunAdet)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTipId", tip);
            cmd.Parameters.AddWithValue("@UrunTurId", tur);
            cmd.Parameters.AddWithValue("@UrunKategoriId", kategori);
            cmd.Parameters.AddWithValue("@UrunKodu", urunKodu);
            cmd.Parameters.AddWithValue("@UrunAd", urunAd);
            cmd.Parameters.AddWithValue("@UrunOzeti", urunOzeti);
            cmd.Parameters.AddWithValue("@UrunAlisFiyati", urunAlisFiyati);
            cmd.Parameters.AddWithValue("@UrunSatisFiyati", urunSatisFiyati);
            cmd.Parameters.AddWithValue("@UrunAdet", urunAdet);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunSil(int urunId)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunId", urunId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunGuncelle(int urunId, int tip, int tur, int kategori, int urunKodu, string urunAd, string urunOzeti, decimal urunAlisFiyati, decimal urunSatisFiyati, int urunAdet)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunGuncelle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunId", urunId);
            cmd.Parameters.AddWithValue("@UrunTipId", tip);
            cmd.Parameters.AddWithValue("@UrunTurId", tur);
            cmd.Parameters.AddWithValue("@UrunKategoriId", kategori);
            cmd.Parameters.AddWithValue("@UrunKodu", urunKodu);
            cmd.Parameters.AddWithValue("@UrunAd", urunAd);
            cmd.Parameters.AddWithValue("@UrunFiyati", urunKodu);
            cmd.Parameters.AddWithValue("@UrunOzeti", urunOzeti);
            cmd.Parameters.AddWithValue("@UrunAlisFiyati", urunAlisFiyati);
            cmd.Parameters.AddWithValue("@UrunSatisFiyati", urunSatisFiyati);
            cmd.Parameters.AddWithValue("@UrunAdet", urunAdet);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable Listele(int urunTipId, string ara, int urunTurId)
        {
            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("sp_UrunListele", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTipId", urunTipId);
            cmd.Parameters.AddWithValue("@Ara", ara);
            cmd.Parameters.AddWithValue("@UrunTurId", urunTurId);
            try
            {
                Connection_Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection_Close();
            }
            return table;
        }


        public DataTable UrunIdListele()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT UrunId, UrunAd FROM Urun", Connection);
            cmd.CommandType = CommandType.Text;

            Connection_Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            Connection_Close();
            return table;
        }
    }
}
