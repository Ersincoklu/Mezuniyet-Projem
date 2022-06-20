using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UrunTurIslemleri:DataConnection
    {
        public int UrunTurEkle(string urunturad)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTurAd", urunturad);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunTurSil(int urunturid)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTurId", urunturid);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunTurGuncelle(int urunturid, string urunturad)
        {

            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTurId", urunturid);
            cmd.Parameters.AddWithValue("@UrunTurAd", urunturad);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable TurListele()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UrunTur", Connection);
            cmd.CommandType = CommandType.Text;

            Connection_Open();
            dt.Load(cmd.ExecuteReader());
            Connection_Close();
            return dt;
        }
    }
}
