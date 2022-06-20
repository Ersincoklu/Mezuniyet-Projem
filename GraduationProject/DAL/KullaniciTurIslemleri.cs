using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class KullaniciTurIslemleri:DataConnection
    {
       
        public int KullaniciTurEKle(string kullaniciturad)
        {
            SqlCommand cmd = new SqlCommand("",Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullaniciTurAd", kullaniciturad);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int KullaniciTurSil(int kullaniciturid)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullaniciTurId", kullaniciturid);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }

        public int KullaniciTurGuncelle(int kullaniciturid, string kullanicituradi)
        {
            SqlCommand cmd = new SqlCommand("", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullaniciTurId", kullaniciturid);
            cmd.Parameters.AddWithValue("@KullaniciTurAd", kullanicituradi);

            Connection_Open();
            int kayit = cmd.ExecuteNonQuery();
            Connection_Close();
            return kayit;
        }
    }
}
