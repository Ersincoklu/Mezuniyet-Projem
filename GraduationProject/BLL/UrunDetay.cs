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
    public class UrunDetay
    {
        private int urunDetayId;
        private double ibmdPuani;
        private string sanatci;

        public int UrunDetayId
        {
            get { return urunDetayId; }
            set { urunDetayId = value; }
        }

        public double IbmdPuani
        {
            get { return ibmdPuani; }
            set { ibmdPuani = value; }
        }
        
        public string Sanatci
        {
            get { return sanatci; }
            set { sanatci = value; }
        }

        public string UrunDetayEkle()
        {
            UrunDetayIslemleri islem = new UrunDetayIslemleri();
            int kayit = islem.UrunDetayEkle(this.ibmdPuani, this.sanatci);
            if (kayit > 0)
                return "Urun detay eklenmesi basarili oldu";
            else
                return "Urun detay eklenmesinde hata olustu";
        }

        public string UrunDetaySil()
        {
            UrunDetayIslemleri islem = new UrunDetayIslemleri();
            int kayit = islem.UrunDetaySil(this.urunDetayId);
            if (kayit > 0)
                return "Urun detay silinmesi basarili oldu";
            else
                return "Urun detay silinmesinde hata olustu";
        }

        public string UrunDetayGuncelle()
        {
            UrunDetayIslemleri islem = new UrunDetayIslemleri();
            int kayit = islem.UrunDetayGuncelle(this.urunDetayId, this.ibmdPuani, this.sanatci);
            if (kayit > 0)
                return "Urun detay silinmesi basarili oldu";
            else
                return "Urun detay silinmesinde hata olustu";
        }
    }
}
