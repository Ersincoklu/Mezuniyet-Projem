using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class HarcamaIslemleri:DataConnection
    {

        public int HarcamaEkle(string giderAd, string metin, decimal fiyat, DateTime harcamaTarihi)
        {
            SqlCommand cmd = new SqlCommand("sp_HarcamaEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@GiderAd", giderAd);
            cmd.Parameters.AddWithValue("@Metin", metin);
            cmd.Parameters.AddWithValue("@Fiyat", fiyat);
            cmd.Parameters.AddWithValue("@HarcamaTarih", harcamaTarihi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int HarcamaGuncelle(int harcamaId, string giderAd, string metin, decimal fiyat, DateTime harcamaTarihi)
        {
            SqlCommand cmd = new SqlCommand("sp_HarcamaGuncelle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HarcamaId", harcamaId);
            cmd.Parameters.AddWithValue("@GiderAd", giderAd);
            cmd.Parameters.AddWithValue("@Metin", metin);
            cmd.Parameters.AddWithValue("@Fiyat", fiyat);
            cmd.Parameters.AddWithValue("@HarcamaTarih", harcamaTarihi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int HarcamaSil(int harcamaId)
        {
            SqlCommand cmd = new SqlCommand("sp_HarcamaSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HarcamaId", harcamaId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable Listele()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Harcamalar", Connection);
            Connection_Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Connection_Close();
            return dt;
        }
    }
}
