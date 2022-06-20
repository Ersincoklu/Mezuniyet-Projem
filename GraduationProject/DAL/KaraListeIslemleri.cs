using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KaraListeIslemleri:DataConnection
    {
        public int Ekle(int musteriId, string metin)
        {
            SqlCommand cmd = new SqlCommand("sp_KaraListeEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            cmd.Parameters.AddWithValue("@Metin", metin);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int Sil(int karaListeId)
        {
            SqlCommand cmd = new SqlCommand("sp_KaraListeSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KaraListeId", karaListeId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int Guncelle(int karaListeId, int musteriId, string metin)
        {
            SqlCommand cmd = new SqlCommand("sp_KaraListeGuncelle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KaraListeId", karaListeId);
            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            cmd.Parameters.AddWithValue("@Metin", metin);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable Listele()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_KaraListeListele", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            Connection_Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            Connection_Close();
            return table;
        }
    }
}
