using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Kasa
    {
        private int kasaId;
        private string kasaAd;

        public int KasaId
        {
            get { return kasaId; }
            set { kasaId = value; }
        }

        public string KasaAd
        {
            get { return kasaAd; }
            set { kasaAd = value; }
        }

        public Kasa()
        {
            this.kasaId = -1;
            this.kasaAd = "";
        }
        public Kasa(int KasaIdd)
        {
            this.kasaId = KasaIdd;
        }

        public string KasaEkle()
        {
            KasaIslemleri islem = new KasaIslemleri();
            int kayit = islem.KasaEkle(this.kasaAd);
            if (kayit > 0)
                return "Kasa eklenmesi basarili oldu";
            else
                return "Kasa eklenmesinde hata oldu";
        }

        public string KasaSil()
        {
            KasaIslemleri islem = new KasaIslemleri();
            int kayit = islem.KasaSil(this.kasaId);
            if (kayit > 0)
                return "Kasa silinmesi basarili oldu";
            else
                return "Kasa silinmesinde hata oldu";
        }

        public string KasaGuncelle()
        {
             KasaIslemleri islem = new KasaIslemleri();
             int kayit = islem.KasaGuncelle(this.kasaId, this.kasaAd);
             if (kayit > 0)
                 return "Kasa guncenlenmesi basarili oldu";
             else
                 return "Kasa guncenlenmesinde hata oldu";
        }

        public DataTable Listele()
        {
            KasaIslemleri islem = new KasaIslemleri();
            return islem.KasaListele();
        }
    }
}
