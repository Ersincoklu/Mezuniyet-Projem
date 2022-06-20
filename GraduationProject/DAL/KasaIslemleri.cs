using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KasaIslemleri:DataConnection
    {
        public int KasaEkle(string kasaAd)
        {
            SqlCommand cmd = new SqlCommand("sp_KasaEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KasaAd", kasaAd);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection.Close();
            return kayit;
        }

        public int KasaSil(int kasaId)
        {
            SqlCommand cmd = new SqlCommand("sp_KasaSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KasaId", kasaId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection.Close();
            return kayit;
        }

        public int KasaGuncelle(int kasaId, string kasaAd)
        {
            SqlCommand cmd = new SqlCommand("sp_KasaGuncelle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KasaId", kasaId);
            cmd.Parameters.AddWithValue("@KasaAd", kasaAd);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection.Close();
            return kayit;
        }

        public DataTable KasaListele()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kasa", Connection);
            Connection_Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Connection_Close();
            return dt;
        }
    }
}
