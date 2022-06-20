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
    public class KaraListee
    {
        private int karaListeId;
        private Musteri musteriId;
        private string metin;

        public int KaraListeId
        {
            get { return karaListeId; }
            set { karaListeId = value; }
        }

        public Musteri MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }

        public string Metin
        {
            get { return metin; }
            set { metin = value; }
        }


        public string Ekle()
        {
            KaraListeIslemleri islem = new KaraListeIslemleri();
            int kayit = islem.Ekle(this.musteriId.MusteriId, this.metin);
            if (kayit > 0)
                return "Ekleme islemi basarili";
            else
                return "Ekleme islemi basarisiz";
        }

        public string Sil()
        {
            KaraListeIslemleri islem = new KaraListeIslemleri();
            int kayit = islem.Sil(this.karaListeId);
            if (kayit > 0)
                return "Silme islemi basarili";
            else
                return "Silme islemi basarisiz";
        }

        public string Guncelle()
        {
            KaraListeIslemleri islem = new KaraListeIslemleri();
            int kayit = islem.Guncelle(this.karaListeId, this.musteriId.MusteriId, this.metin);
            if (kayit > 0)
                return "Guncelleme islemi basarili";
            else
                return "Guncelleme islemi basarisiz";
        }

        public DataTable Listele()
        {
            KaraListeIslemleri islem = new KaraListeIslemleri();
            return islem.Listele();
        }

    }
}
