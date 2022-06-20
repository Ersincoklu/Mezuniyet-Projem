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
    public class UrunKiralama
    {
        private int urunKiralamaId;
        private UrunTip urunTip;
        private UrunTur urunTur;
        private Urun urunId;
        private Musteri musteriId;
        private decimal urunKiraBedeli;
        private DateTime urunBaslangicTarih;
        private DateTime urunBitisTarih;


        public int UrunKiralamaId
        {
            get { return urunKiralamaId; }
            set { urunKiralamaId = value; }
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

        public decimal UrunKiraBedeli
        {
            get { return urunKiraBedeli; }
            set { urunKiraBedeli = value; }
        }
        
        public DateTime UrunBaslangicTarih
        {
            get { return urunBaslangicTarih; }
            set { urunBaslangicTarih = value; }
        }
        
        public DateTime UrunBitisTarih
        {
            get { return urunBitisTarih; }
            set { urunBitisTarih = value; }
        }

        public string KiraEkle()
        {
            UrunKiralamaIslemleri islem = new UrunKiralamaIslemleri();
            int kayit = islem.UrunKiralamaEkle(this.urunTip.Uruntipid, this.urunTur.Urunturid, this.urunId.UrunId, this.musteriId.MusteriId, this.urunKiraBedeli, this.urunBaslangicTarih, this.urunBitisTarih);
            if (kayit > 0)
                return "Urun kiralama basarili bir sekilde eklendi";
            else
                return "Urun kiralama eklenirken hata olustu";
        }

        public string KiraSil()
        {
            UrunKiralamaIslemleri islem = new UrunKiralamaIslemleri();
            int kayit = islem.UrunKiralamaSil(this.urunKiralamaId);
            if (kayit > 0)
                return "Urun kiralama basarili bir sekilde silindi";
            else
                return "Urun kiralama silinirken hata olustu";
        }

        public string KiraGuncelle()
        {
            UrunKiralamaIslemleri islem = new UrunKiralamaIslemleri();
            int kayit = islem.UrunKiralamaGuncelleme(this.urunKiralamaId,this.urunTip.Uruntipid, this.urunTur.Urunturid, this.urunId.UrunId, this.musteriId.MusteriId, this.urunKiraBedeli, this.urunBaslangicTarih, this.urunBitisTarih);
            if (kayit > 0)
                return "Urun kiralama basarili bir şekilde guncellendi ";
            else
                return "Urun kiralama guncenlenirken hata olustu";
        }

        public DataTable KiraListele()
        {
            UrunKiralamaIslemleri islem = new UrunKiralamaIslemleri();
            return islem.Listele();
        }

    }
}
