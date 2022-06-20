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
    public class Harcama
    {
//Ersin ÇOKLU
        private int harcamaId;
        private string giderAd;
        private string metin;
        private decimal fiyat;
        private DateTime harcamaTarih;

        public int HarcamaId
        {
            get { return harcamaId; }
            set { harcamaId = value; }
        }

        public string GiderAd
        {
            get { return giderAd; }
            set { giderAd = value; }
        }

        public string Metin
        {
            get { return metin; }
            set { metin = value; }
        }

        public decimal Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }

        public DateTime HarcamaTarih
        {
            get { return harcamaTarih; }
            set { harcamaTarih = value; }
        }

        public string HarcamaEkle()
        {
            HarcamaIslemleri islem = new HarcamaIslemleri();
            int kayit = islem.HarcamaEkle(this.giderAd, this.metin, this.fiyat, this.harcamaTarih);
            if (kayit > 0)
            {
                return "Harcama ekleme işlemi başarılı";
            }
            else
            {
                return "Harcama ekleme işleminde sorun oluştu";
            }
        }

        public string HarcamaSil()
        {
            HarcamaIslemleri islem = new HarcamaIslemleri();
            int kayit = islem.HarcamaSil(this.harcamaId);
            if (kayit > 0)
            {
                return "Harcama silinme işlemi başarılı";
            }
            else
            {
                return "Harcama silinme işleminde sorun oluştu";
            }
        }

        public string HarcamaGuncelle()
        {
            HarcamaIslemleri islem = new HarcamaIslemleri();
            int kayit = islem.HarcamaGuncelle(this.harcamaId, this.giderAd, this.metin, this.fiyat, this.harcamaTarih);
            if (kayit > 0)
            {
                return "Harcama güncelle işlemi başarılı";
            }
            else
            {
                return "Harcama güncelleme işleminde sorun oluştu";
            }
        }

        public DataTable Listele()
        {
            HarcamaIslemleri islem = new HarcamaIslemleri();
            return islem.Listele();
        }
    }
}