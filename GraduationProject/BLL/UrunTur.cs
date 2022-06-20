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
    public class UrunTur
    {
        private int urunturid;
        private string urunturad;

        public int Urunturid
        {
            get { return urunturid; }
            set { urunturid = value; }
        }

        public string Urunturad
        {
            get { return urunturad; }
            set { urunturad = value; }
        }

        public UrunTur(int urunTurId)
        {
            this.urunturid = urunTurId;
        }

        public string UrunTurEkle()
        {
            UrunTurIslemleri islem = new UrunTurIslemleri();
            int kayit = islem.UrunTurEkle(this.urunturad);
            if (kayit > 0)
                return "Urun tur eklenmesi basarili oldu";
            else
                return "Urun tur eklenmesinde hata olustu";
        }

        public string UrunTurSil()
        {
            UrunTurIslemleri islem = new UrunTurIslemleri();
            int kayit = islem.UrunTurSil(this.urunturid);
            if(kayit > 0)
                return "Urun tur silinmesi basarili oldu";
            else
                return "Urun tur silinmesinde hata olustu";
        }

        public string UrunTurGuncelle()
        {
            UrunTurIslemleri islem = new UrunTurIslemleri();
            int kayit = islem.UrunTurGuncelle(this.urunturid, this.urunturad);
            if (kayit > 0)
                return "Urun tur guncellenmesi basarili oldu";
            else
                return "Urun tur guncellenmesinde hata olustu";
        }

        public DataTable TurListele()
        {
            UrunTurIslemleri islem = new UrunTurIslemleri();
            return islem.TurListele();
        }

    }
}
