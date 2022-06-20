using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UrunDetayIslemleri:DataConnection
    {
        public int UrunDetayEkle(double imbdPuani, string sanatci)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IbmdPuani", imbdPuani);
            cmd.Parameters.AddWithValue("@Sanatci", sanatci);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunDetaySil(int urunDetayId)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunDetayId", urunDetayId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int UrunDetayGuncelle(int urunDetayId, double imbdPuani, string sanatci)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunDetayId", urunDetayId);
            cmd.Parameters.AddWithValue("@IbmdPuani", imbdPuani);
            cmd.Parameters.AddWithValue("@Sanatci", sanatci);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }
    }
}
