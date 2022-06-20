using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UrunKategoriIslemleri:DataConnection
    {
        public int UrunKategoriEkle(string urunKategoriAd)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunKategoriAd", urunKategoriAd);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunKategoriSil(int urunKategoriId)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunKategoriId", urunKategoriId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunKategoriGuncelle(int urunKategoriId, string urunKategoriAd)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunKategoriId", urunKategoriId);
            cmd.Parameters.AddWithValue("@UrunKategoriAd", urunKategoriAd);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable KategoriListele()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UrunKategori", Connection);
            cmd.CommandType = CommandType.Text;

            Connection_Open();
            dt.Load(cmd.ExecuteReader());
            Connection_Close();
            return dt;
        }
    }
}
