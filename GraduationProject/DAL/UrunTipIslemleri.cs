using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UrunTipIslemleri:DataConnection
    {
        public int UrunTipEkle(string uruntipad)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTipAd", uruntipad);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunTipSil(int uruntipid)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTipId", uruntipid);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunTipGuncelle(int uruntipid, string uruntipad)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunTipId", uruntipid);
            cmd.Parameters.AddWithValue("@UrunTipAd", uruntipad);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public DataTable TipListele()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UrunTip", Connection);
            cmd.CommandType = CommandType.Text;

            Connection_Open();
            dt.Load(cmd.ExecuteReader());
            Connection_Close();
            return dt;
        }
    }
}
