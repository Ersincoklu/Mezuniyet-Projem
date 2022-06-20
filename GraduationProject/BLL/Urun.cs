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
    public class Urun:DataConnection
    {
        private int urunId;
        private UrunTip urunTip;
        private UrunTur urunTur;
        private UrunKategori urunKategori;
        private int urunKodu;
        private string urunAd;
        private string urunOzeti;
        private decimal urunAlisFiyati;
        private decimal urunSatisFiyati;
        private int urunAdet;

        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }

        public UrunTip UrunTip
        {
            get { return urunTip; }
            set { urunTip = value; }
        }

        public UrunTur UrunTur
        {
            get { return urunTur; }
            set { urunTur = value; }
        }

        public UrunKategori UrunKategori
        {
            get { return urunKategori; }
            set { urunKategori = value; }
        }

        public int UrunKodu
        {
            get { return urunKodu; }
            set { urunKodu = value; }
        }

        public string UrunAd
        {
            get { return urunAd; }
            set { urunAd = value; }
        }

        public string UrunOzeti
        {
            get { return urunOzeti; }
            set { urunOzeti = value; }
        }

        public decimal UrunAlisFiyati
        {
            get { return urunAlisFiyati; }
            set { urunAlisFiyati = value; }
        }

        public decimal UrunSatisFiyati
        {
            get { return urunSatisFiyati; }
            set { urunSatisFiyati = value; }
        }

        public int UrunAdet
        {
            get { return urunAdet; }
            set { urunAdet = value; }
        }

        public string UrunEkle()
        {
            UrunIslemleri islem = new UrunIslemleri();
            int kayit = islem.UrunEkle(this.urunTip.Uruntipid, this.urunTur.Urunturid, this.urunKategori.UrunKategoriId, this.urunKodu, this.urunAd, this.urunOzeti, this.urunAlisFiyati, this.urunSatisFiyati, this.urunAdet);
            if (kayit > 0)
                return "Urun eklenmesi basarili oldu";
            else
                return "Urun eklenmesinde hata oluştu. (Aynı ürün kodu zaten var)";
        }

        public string UrunSil()
        {
            UrunIslemleri islem = new UrunIslemleri();
            int kayit = islem.UrunSil(this.urunId);
            if (kayit > 0)
                return "Urun silinmesi basarili oldu";
            else
                return "Urun silinmesinde hata olustu";
        }

        public string UrunGuncelle()
        {
            UrunIslemleri islem = new UrunIslemleri();
            int kayit = islem.UrunGuncelle(this.urunId, this.urunTip.Uruntipid, this.urunTur.Urunturid, this.urunKategori.UrunKategoriId, this.urunKodu, this.urunAd, this.urunOzeti, this.urunAlisFiyati, this.urunSatisFiyati, this.urunAdet);
            if (kayit > 0)
                return "Urun guncellenmesi basarili oldu";
            else
                return "Urun guncellenmesinde hata olustu (Aynı ürün kodu zaten var)";
        }


        public DataTable UrunListele(int urunTipId, string ara, int urunTurId)
        {
            UrunIslemleri islem = new UrunIslemleri();
            return islem.Listele(urunTipId, ara, urunTurId);
        }

        public DataTable UrunIdListeler()
        {
            UrunIslemleri islem = new UrunIslemleri();
            return islem.UrunIdListele();
        }
    }
}
