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
    public class Musteri
    {
        private int musteriid;
        private string musteriAd;
        private string musteriSoyad;
        private string musteriTc;
        private string musteriCepNo;
        private char musteriCinsiyet;
        private string musteriMail;
        private string musteriAdres;
        private string musteriNot;
        private bool aktif;

        public int MusteriId
        {
            get { return musteriid; }
            set { musteriid = value; }
        }

        
        public string MusteriAd
        {
            get { return musteriAd; }
            set { musteriAd = value; }
        }
     

        public string MusteriSoyad
        {
            get { return musteriSoyad; }
            set { musteriSoyad = value; }
        }
        

        public string MusteriTc
        {
            get { return musteriTc; }
            set { musteriTc = value; }
        }
        

        public string MusteriCepNo
        {
            get { return musteriCepNo; }
            set { musteriCepNo = value; }
        }
       

        public char MusteriCinsiyet
        {
            get { return musteriCinsiyet; }
            set { musteriCinsiyet = value; }
        }
       

        public string MusteriMail
        {
            get { return musteriMail; }
            set { musteriMail = value; }
        }
        

        public string MusteriAdres
        {
            get { return musteriAdres; }
            set { musteriAdres = value; }
        }
        

        public string MusteriNot
        {
            get { return musteriNot; }
            set { musteriNot = value; }
        }
        

        public bool Aktif
        {
            get { return aktif; }
            set { aktif = value; }
        }

        public string MusteriEkle()
        {
            MusteriIslemleri islem = new MusteriIslemleri();
            int kayit = islem.MusteriEkle(this.musteriAd, this.musteriSoyad, this.musteriTc, this.musteriCepNo, this.musteriCinsiyet, this.musteriMail, this.musteriAdres, this.musteriNot, this.aktif);
                if (kayit > 0)
                    return "Kayıt islemi basarılı";
                else
                    return "Kayıt işleminde hata oluştu!! (Aynı T.C'li müşteri var veya T.C numarası karalistede var)";
	    }

        public string MusteriSil()
        {
            MusteriIslemleri islem = new MusteriIslemleri();
            int kayit = islem.MusteriSil(this.musteriid);
            if (kayit > 0)
                return "Silme islemi basarili";
            else
                return "Hata olustu";
        }

        public string MusteriGuncelle()
        {
            MusteriIslemleri islem = new MusteriIslemleri();
            int kayit = islem.MusteriGuncelle(this.musteriid, this.musteriAd, this.musteriSoyad, this.musteriTc, this.musteriCepNo, this.musteriCinsiyet, this.musteriMail, this.musteriAdres, this.musteriNot, this.aktif);
            if (kayit > 0)
                return "Guncelleme islemi basarili";
            else
                return "Guncelleme yaparken hata olustu";
        }

        public DataTable MusteriListele()
        {
            MusteriIslemleri islem = new MusteriIslemleri();
            return islem.Listele();
        }

        public string KaraListeEkle(int musteriId, string metin)
        {
            MusteriIslemleri islem = new MusteriIslemleri();
            int kayit = islem.MusteriKaraListeEkle(musteriId, metin);
            if (kayit > 0)
                return "Kayıt islemi basarılı";
            else
                return "Hata";
        }

        public string KaraListeSilme(int musteriId)
        {
            MusteriIslemleri islem = new MusteriIslemleri();
            int kayit = islem.MusteriKaraListeSil(musteriId);
            if (kayit > 0)
                return "Silme islemi basarılı";
            else
                return "Hata";
        }

        public DataTable musteriIdListele()
        {
            MusteriIslemleri islem = new MusteriIslemleri();
            return islem.musteriIdListele();
        }
    }
}
