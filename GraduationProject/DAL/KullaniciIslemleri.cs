using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KullaniciIslemleri:DataConnection
    {
        public int KullaniciGiris(string kullaniciadi, string kullanicisifre)
        {
            SqlCommand cmd = new SqlCommand("sp_KullaniciGiris", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciadi);
            cmd.Parameters.AddWithValue("@KullaniciSifre", kullanicisifre);

            Connection_Open();
            int kayit  = Convert.ToInt32(cmd.ExecuteScalar());
            Connection_Close();
            return kayit;
        }

        public int KullaniciEkle(string kullaniciadi, string kullanicisifre)
        {
            SqlCommand cmd = new SqlCommand("sp_KullaniciEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciadi);
            cmd.Parameters.AddWithValue("@KullaniciSifre", kullanicisifre);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int KullaniciSil(int kullaniciid)
        {
            SqlCommand cmd = new SqlCommand("sp_KullaniciSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullaniciId", kullaniciid);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int KullaniciGuncelle(int kullaniciid, string kullaniciadi, string kullanicisifre)
        {
            SqlCommand cmd = new SqlCommand("sp_KullaniciGuncelle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullaniciId", kullaniciid);
            cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciadi);
            cmd.Parameters.AddWithValue("@KullaniciSifre", kullanicisifre);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable Listele()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar", Connection);
            Connection_Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            Connection_Close();
            return table;
        }
    }
}
