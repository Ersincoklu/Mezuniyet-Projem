using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UrunStok
    {
        private int urunStokId;
        private int urunStokAdet;
        private DateTime urunGelisTarihi;

        public int UrunStokId
        {
            get { return urunStokId; }
            set { urunStokId = value; }
        }

        public int UrunStokAdet
        {
            get { return urunStokAdet; }
            set { urunStokAdet = value; }
        }

        public DateTime UrunGelisTarihi
        {
            get { return urunGelisTarihi; }
            set { urunGelisTarihi = value; }
        }

        public string UrunStokEkle()
        {
            UrunStokIslemleri islem = new UrunStokIslemleri();
            int kayit = islem.UrunStokEkle(this.urunStokAdet, this.urunGelisTarihi);
            if (kayit > 0 )
                return "Urun stok eklenmesi basarili oldu";
            else
                return "Urun stok eklenmesinde hata olustu";
        }

        public string UrunStokSil()
        {
            UrunStokIslemleri islem = new UrunStokIslemleri();
            int kayit = islem.UrunStokSil(this.urunStokId);
            if (kayit > 0)
                return "Urun stok silinmesi basarili oldu";
            else
                return "Urun stok silinmesinde hata olustu";
        }

        public string UrunStokGuncelle()
        {
            UrunStokIslemleri islem = new UrunStokIslemleri();
            int kayit = islem.UrunStokGuncelle(this.urunStokId, this.urunStokAdet, this.urunGelisTarihi);
            if (kayit > 0)
                return "Urun stok guncellenmesi basarili oldu";
            else
                return "Urun stok guncellenmesinde hata olustu";
        }
    }
}
