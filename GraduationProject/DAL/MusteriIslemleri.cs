using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class MusteriIslemleri:DataConnection
    {
        public int MusteriEkle(string musteriad, string musterisoyad, string musteritc, string mustericepno, char mustericinsiyet, string musterimail, string musteriadres, string musterinot, bool aktif)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriAd",musteriad);
            cmd.Parameters.AddWithValue("@MusteriSoyad",musterisoyad);
            cmd.Parameters.AddWithValue("@MusteriTc",musteritc);
            cmd.Parameters.AddWithValue("@MusteriCepNo", mustericepno);
            cmd.Parameters.AddWithValue("@MusteriCinsiyet",mustericinsiyet);
            cmd.Parameters.AddWithValue("@MusteriMail",musterimail);
            cmd.Parameters.AddWithValue("@MusteriAdres",musteriadres);
            cmd.Parameters.AddWithValue("@MusteriNot",musterinot);
            cmd.Parameters.AddWithValue("@Aktif", aktif);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection.Close();
            return kayit;
        }

        public int MusteriSil(int musteriId)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int MusteriGuncelle(int musteriid, string musteriad, string musterisoyad, string musteritc, string mustericepno, char mustericinsiyet, string musterimail, string musteriadres, string musterinot, bool aktif)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriGuncelle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriId", musteriid);
            cmd.Parameters.AddWithValue("@MusteriAd", musteriad);
            cmd.Parameters.AddWithValue("@MusteriSoyad", musterisoyad);
            cmd.Parameters.AddWithValue("@MusteriTc", musteritc);
            cmd.Parameters.AddWithValue("@MusteriCepNo", mustericepno);
            cmd.Parameters.AddWithValue("@MusteriCinsiyet", mustericinsiyet);
            cmd.Parameters.AddWithValue("@MusteriMail", musterimail);
            cmd.Parameters.AddWithValue("@MusteriAdres", musteriadres);
            cmd.Parameters.AddWithValue("@MusteriNot", musterinot);
            cmd.Parameters.AddWithValue("@Aktif", aktif);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int MusteriKaraListeEkle(int musteriId, string metin)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriKaraListeEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            cmd.Parameters.AddWithValue("@Metin", metin);
            Connection_Open();
            int kayit = 0;
            try
            {
                kayit = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            Connection_Close();
            return kayit;
        }

        public int MusteriKaraListeSil(int musteriId)
        {
            SqlCommand cmd = new SqlCommand("sp_MusteriKaraListeSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            Connection_Open();
            int kayit = 0;
            try
            {
                kayit = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            Connection_Close();
            return kayit;
        }

        public DataTable Listele()
        {
            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Musteri WHERE MusteriId NOT IN (SELECT MusteriId FROM KaraListe)", Connection);
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

        public DataTable musteriIdListele()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MusteriId, MusteriAd, MusteriSoyad FROM Musteri ", Connection);
            Connection_Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            Connection_Close();
            return table;
        }

    }
}
