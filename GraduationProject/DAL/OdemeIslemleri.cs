using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class OdemeIslemleri:DataConnection
    {
        public int OdemeEkle(string odemeTipi)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OdemeTipi", odemeTipi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int OdemeSil(int odemeId)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OdemeID", odemeId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int OdemeGuncelle(int odemeId, string odemeTipi)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OdemeID", odemeId);
            cmd.Parameters.AddWithValue("@OdemeTipi", odemeTipi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable Listele()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Odeme", Connection);
            cmd.CommandType = CommandType.Text;

            Connection_Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            Connection_Close();
            return table;
        }

    }
}
