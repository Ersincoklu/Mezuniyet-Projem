using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DataConnection
    {
        private SqlConnection con = new SqlConnection("server=.;database =DvdVcdOtomasyon;Integrated Security = true");
        public SqlConnection Connection
        {
            get { return con; }
        }

        public void Connection_Open()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            catch (TimeoutException ex)
            {
                throw new Exception(ex.Message);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Connection_Close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
