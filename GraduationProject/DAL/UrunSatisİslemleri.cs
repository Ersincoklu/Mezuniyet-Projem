using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UrunSatisİslemleri:DataConnection
    {
        public int UrunSatisEkle(int urunId, int musteriId, int kasa, int odeme)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunSatisEkle", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunId", urunId);
            cmd.Parameters.AddWithValue("@MusteriId", musteriId);
            cmd.Parameters.AddWithValue("@KasaId", kasa);
            cmd.Parameters.AddWithValue("@OdemeID", odeme );

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
            SqlCommand cmd = new SqlCommand("SELECT * FROM UrunSatis", Connection);
            cmd.CommandType = CommandType.Text;
            Connection_Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            Connection_Close();
            return table;

        }

        
    }
}
