using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class UrunKategori
    {
        private int urunKategoriId;
        private string urunKategoriAd;
        private bool aktif;

        public int UrunKategoriId
        {
            get { return urunKategoriId; }
            set { urunKategoriId = value; }
        }

        public string UrunKategoriAd
        {
            get { return urunKategoriAd; }
            set { urunKategoriAd = value; }
        }

        public bool Aktif
        {
            get { return aktif; }
            set { aktif = value; }
        }

        public UrunKategori(int kategoriId)
        {
            this.urunKategoriId = kategoriId;
        }

        public string UrunKategoriEkle()
        {
            UrunKategoriIslemleri islem = new UrunKategoriIslemleri();
            int kayit = islem.UrunKategoriEkle(this.urunKategoriAd);
            if (kayit > 0)
                return "Urun kategori eklenmesi basarili oldu";
            else
                return "Urun kategori eklenmesinde hata olustu";
        }

        public string UrunKategoriSil()
        {
            UrunKategoriIslemleri islem = new UrunKategoriIslemleri();
            int kayit = islem.UrunKategoriSil(this.urunKategoriId);
            if (kayit > 0)
                return "Urun kategori silinmesi basarili oldu";
            else
                return "Urun kategori silinmesinde hata olustu";
        }

        public string UrunGuncelle()
        {
            UrunKategoriIslemleri islem = new UrunKategoriIslemleri();
            int kayit = islem.UrunKategoriGuncelle(this.urunKategoriId, this.urunKategoriAd);
            if (kayit > 0)
                return "Urun kategori guncellenmesi basarili oldu";
            else
                return "Urun kategori guncellenmesinde hata olustu";
        }

        public DataTable KategoriListele()
        {
            UrunKategoriIslemleri islem = new UrunKategoriIslemleri();
            return islem.KategoriListele();
        }
    }
}
