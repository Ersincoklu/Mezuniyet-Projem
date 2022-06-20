using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace BLL
{
    public class Odeme
    {
        private int odemeId;
        private string odemeTipi;

        public int OdemeId
        {
            get { return odemeId; }
            set { odemeId = value; }
        }
        
        public string OdemeTipi
        {
            get { return odemeTipi; }
            set { odemeTipi = value; }
        }

        public Odeme()
        {
            this.odemeId = -1;
            this.odemeTipi = "";
        }

        public Odeme(int odemeIdd)
        {
            this.odemeId = odemeIdd;
        }
       
        public string OdemeEkle()
        {
            OdemeIslemleri islem = new OdemeIslemleri();
            int kayit = islem.OdemeEkle(this.odemeTipi);
            if (kayit > 0)
                return "Odeme eklenmesi basarili oldu";
            else
                return "Odeme eklenmesinde hata olustu";
        }

        public string OdemeSil()
        {
            OdemeIslemleri islem = new OdemeIslemleri();
            int kayit = islem.OdemeSil(this.odemeId);
            if (kayit > 0)
                return "Odeme silinmesi basarili oldu";
            else
                return "Odeme silinmesinde hata olustu";
        }

        public string OdemeGuncelle()
        {
            OdemeIslemleri islem = new OdemeIslemleri();
            int kayit = islem.OdemeGuncelle(this.odemeId, this.odemeTipi);
            if (kayit > 0)
                return "Odeme silinmesi basarili oldu";
            else
                return "Odeme silinmesinde hata olustu";
        }

        public DataTable Listele()
        {
            OdemeIslemleri islem = new OdemeIslemleri();
            return islem.Listele();
        }
    }
}
