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
    public class UrunSatiss
    {
        private int urunSatisId = 0;
        private Urun urunId = new Urun();
        private Musteri musteriId = new Musteri();
        private Kasa kasaId = new Kasa();
        private Odeme odemeId = new Odeme();
        private int adet = 0;
               
        public int UrunSatisId
        {
            get { return urunSatisId; }
            set { urunSatisId = value; }
        }

        public Urun UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }

        public Musteri MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }

        public Kasa KasaId
        {
            get { return kasaId; }
            set { kasaId = value; }
        }

        public Odeme OdemeId
        {
            get { return odemeId; }
            set { odemeId = value; }
        }

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }


        public string UrunSatisEkle()
        {
            UrunSatisİslemleri islem = new UrunSatisİslemleri();
            int kayit = islem.UrunSatisEkle(this.urunId.UrunId, this.musteriId.MusteriId, this.kasaId.KasaId, this.odemeId.OdemeId);
            if(kayit > 0 )
                return "Urun satis eklenmesi basarili oldu";
            else
                return "Urun satis eklenmesinde hata oldu";
        }

        public DataTable Listele()
        {
            UrunSatisİslemleri islem = new UrunSatisİslemleri();
            return islem.Listele();
        }
    }
}
