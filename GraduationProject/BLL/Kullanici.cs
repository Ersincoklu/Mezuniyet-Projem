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
    public class Kullanici:DataConnection
    {
        public int kullaniciid;
        public string kullaniciadi;
        public string kullanicisifre;

        public int Kullaniciid
        {
            get { return kullaniciid; }
            set { kullaniciid = value; }
        } 
        
        public string Kullaniciadi
        {
            get { return kullaniciadi; }
            set { kullaniciadi = value; }
        }

        public string Kullanicisifre
        {
            get { return kullanicisifre; }
            set { kullanicisifre = value; }
        }

        //public Kullanici(string kullaniciadi, string kullanicisifresi)
        //{
        //    this.kullaniciadi = kullaniciadi;
        //    this.kullanicisifre = kullanicisifresi;
        //}

        public bool KullaniciGiris()
        {
            KullaniciIslemleri islem = new KullaniciIslemleri();
            int kayit = islem.KullaniciGiris(this.kullaniciadi, this.kullanicisifre);
            if (kayit > 0)
                return true;
            else
                return false;
        }

        public string KullaniciEkle()
        {
            KullaniciIslemleri islem = new KullaniciIslemleri();
            int kayit = islem.KullaniciEkle(this.kullaniciadi, this.kullanicisifre);
            if (kayit > 0)
                return "Kullanici basarili bir sekilde eklendi";
            else
                return "Kullanici eklerken hata olustu!!";
        }

        public string KullaniciSil()
        {
            KullaniciIslemleri islem = new KullaniciIslemleri();
            int kayit = islem.KullaniciSil(this.kullaniciid);
            if (kayit > 0)
                return "Kullanici silindi ";
            else
                return "Kullanici silerken hata olustu";
        }

        public string KullaniciGuncelle()
        {
            KullaniciIslemleri islem = new KullaniciIslemleri();
            int kayit = islem.KullaniciGuncelle(this.kullaniciid, this.kullaniciadi, this.kullanicisifre);
            if (kayit > 0)
                return "Kullanici guncellendi";
            else
                return "Kullanici guncellerken hata ile karsilasildi";
        }

        public DataTable Listele()
        {
            KullaniciIslemleri islem = new KullaniciIslemleri();
            return islem.Listele();
        }

    }
}
