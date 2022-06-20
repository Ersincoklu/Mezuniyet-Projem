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
    public class KullaniciTur
    {
        private int kullaniciturId;
        public  Kullanici kullaniciId;
        private string kullanicituradi;

        public int Kullaniciturid
        {
            get { return kullaniciturId; }
            set { kullaniciturId = value; }
        }
       
        public Kullanici KullaniciId
        {
            get { return kullaniciId; }
            set { kullaniciId = value; }
        }

        public string KullaniciTurAdi
        {
            get { return kullanicituradi; }
            set { kullanicituradi = value; }
        }

        public string KullaniciTurEkle()
        {
            KullaniciTurIslemleri islem = new KullaniciTurIslemleri();
            int kayit = islem.KullaniciTurEKle(this.kullanicituradi);
            if (kayit > 0)
                return "Kullanici tur ekleme basarili";
            else
                return "Kullanici tur eklerken hata olustu";
        }

        public string KullaniciTurSil()
        {
            KullaniciTurIslemleri islem = new KullaniciTurIslemleri();
            int kayit = islem.KullaniciTurSil(this.kullaniciturId);
            if (kayit > 0)
                return "Kullanici tur silme islemi basarili";
            else
                return "Kullanici tur silerken hata olustur";
        }

        public string KullaniciTurGuncelle()
        {
            KullaniciTurIslemleri islem = new KullaniciTurIslemleri();
            int kayit = islem.KullaniciTurGuncelle(this.kullaniciturId, this.kullanicituradi);
            if (kayit > 0)
                return "Kullanici tur guncelleme islemi basarali";
            else
                return "Kullanici tur guncellerken hata olustu";
        }


    }
}
