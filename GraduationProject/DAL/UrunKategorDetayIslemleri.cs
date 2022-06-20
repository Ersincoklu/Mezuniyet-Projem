using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UrunKategorDetayIslemleri:DataConnection
    {
        public int UrunKategoriDetayEkle(string urunKategoriDetayAd)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunKategoriDetayAd", urunKategoriDetayAd);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunKategoriDetaySil(int urunKategoriDetayId)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunKategoriDetayId", urunKategoriDetayId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunKategoriDetayGuncelle(int urunKategoriDetayId, string urunKategoriDetayAd)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunKategoriDetayId", urunKategoriDetayId);
            cmd.Parameters.AddWithValue("@UrunKategoriDetayAd", urunKategoriDetayAd);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

    }
}
