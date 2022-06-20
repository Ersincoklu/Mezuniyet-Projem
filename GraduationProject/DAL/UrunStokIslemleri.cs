using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UrunStokIslemleri:DataConnection
    {
        public int UrunStokEkle(int urunAdet, DateTime urunGelisTarihi)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunAdet", urunAdet);
            cmd.Parameters.AddWithValue("@UrunGelisTarihi", urunGelisTarihi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection.Close();
            return kayit;
        }

        public int UrunStokSil(int urunStokId)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunStokId", urunStokId);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection.Close();
            return kayit;
        }

        public int UrunStokGuncelle(int urunStokId, int urunAdet, DateTime urunGelisTarihi)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunStokId", urunStokId);
            cmd.Parameters.AddWithValue("@UrunAdet", urunAdet);
            cmd.Parameters.AddWithValue("@UrunGelisTarihi", urunGelisTarihi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection.Close();
            return kayit;
        }
    }
}
