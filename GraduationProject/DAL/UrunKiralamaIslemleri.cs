using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UrunKiralamaIslemleri:DataConnection
    {
        public int UrunKiralamaEkle(int tip, int tur, int urun, int musteri, decimal urunKiralamaBedeli, DateTime urunBaslangicTarihi, DateTime urunBitisTarihi)
        {
            SqlCommand cmd = new SqlCommand("sp_KiraEklee", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTip", tip);
            cmd.Parameters.AddWithValue("@UrunTur", tur);
            cmd.Parameters.AddWithValue("@UrunId", urun);
            cmd.Parameters.AddWithValue("@MusteriId", musteri);
            cmd.Parameters.AddWithValue("@KiraBedeli", urunKiralamaBedeli);
            cmd.Parameters.AddWithValue("@KiraBaslangicTarihi", urunBaslangicTarihi);
            cmd.Parameters.AddWithValue("@KiraBitisTarihi", urunBitisTarihi);
            
            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }
        
        public int UrunKiralamaSil(int urunKiramaId)
        {
            SqlCommand cmd = new SqlCommand("sp_KiraSil", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KiraId", urunKiramaId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunKiralamaGuncelleme(int urunKiramaId, int tip, int tur, int urun, int musteri, decimal urunKiralamaBedeli, DateTime urunBaslangicTarihi, DateTime urunBitisTarihi)
        {
            SqlCommand cmd = new SqlCommand("sp_KiraGuncelle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KiraId", urunKiramaId);
            cmd.Parameters.AddWithValue("@UrunTip", tip);
            cmd.Parameters.AddWithValue("@UrunTur", tur);
            cmd.Parameters.AddWithValue("@UrunId", urun);
            cmd.Parameters.AddWithValue("@MusteriId", musteri);
            cmd.Parameters.AddWithValue("@KiraBedeli", urunKiralamaBedeli);
            cmd.Parameters.AddWithValue("@KiraBaslangicTarihi", urunBaslangicTarihi);
            cmd.Parameters.AddWithValue("@KiraBitisTarihi", urunBitisTarihi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable Listele()
        {
            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("sp_KiralamaaListele", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
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
    }
}
