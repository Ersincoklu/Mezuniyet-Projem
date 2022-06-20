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
    public class UrunKategoriDetay
    {
        private int urunKategoriDetayId;
        private string urunKategoriDetayAd;

        public int UrunKategoriDetayId
        {
          get { return urunKategoriDetayId; }
          set { urunKategoriDetayId = value; }
        }
                
        public string UrunKategoriDetayAd
        {
          get { return urunKategoriDetayAd; }
          set { urunKategoriDetayAd = value; }
        }

        public string UrunKategoriDetayEkle()
        {
            UrunKategorDetayIslemleri islem = new UrunKategorDetayIslemleri();
            int kayit = islem.UrunKategoriDetayEkle(this.urunKategoriDetayAd);
            if (kayit > 0)
                return "Urun kategori detay eklenmesi basarili oldu";
            else
                return "Urun kategori detay eklenmesinde hata olustu";
        }

        public string UrunKategoriDetaySil()
        {
            UrunKategorDetayIslemleri islem = new UrunKategorDetayIslemleri();
            int kayit = islem.UrunKategoriDetaySil(this.urunKategoriDetayId);
            if (kayit > 0)
                return "Urun kategori detay silinmesi basarili oldu";
            else
                return "Urun kategori detay silinmesinde hata olustu";
        }

        public string UrunKategoriDetayGuncelle()
        {
            UrunKategorDetayIslemleri islem = new UrunKategorDetayIslemleri();
            int kayit = islem.UrunKategoriDetayGuncelle(this.urunKategoriDetayId, this.urunKategoriDetayAd);
            if (kayit > 0)
                return "Urun kategori detay guncellenmesi basarili oldu";
            else
                return "Urun kategori detay guncellenmesinde hata olustu";
        }

    }
}
