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
    public class UrunTip
    {
        private int uruntipid;
        private string uruntipad;

        public int Uruntipid
        {
            get { return uruntipid; }
            set { uruntipid = value; }
        }
    
        public string Uruntipad
        {
            get { return uruntipad; }
            set { uruntipad = value; }
        }

        public UrunTip(int urunTipId)
        {
            this.uruntipid = urunTipId;
        }

        public string UrunTipEkle()
        {
            UrunTipIslemleri islem = new UrunTipIslemleri();
            int kayit = islem.UrunTipEkle(this.uruntipad);
            if (kayit > 0)
                return "Urun tip basarili bir sekilde eklendi";
            else
                return "Urun tip eklenirken hata olustu";
        }

        public string UrunTipSil()
        {
            UrunTipIslemleri islem = new UrunTipIslemleri();
            int kayit = islem.UrunTipSil(this.uruntipid);
            if (kayit > 0)
                return "Urun tip basarili bir sekilde silindi";
            else
                return "Urun tip silinirken hata olustu";
        }

        public string UrunTipGuncelle()
        { 
             UrunTipIslemleri islem = new UrunTipIslemleri();
             int kayit = islem.UrunTipGuncelle(this.uruntipid, this.uruntipad);
             if (kayit > 0)
                 return "Urun tip basarili bir sekilde guncellendi";
             else
                 return "Urun tip guncellenirken hata olustu";
        }

        public DataTable TipListelee()
        {
            UrunTipIslemleri islem = new UrunTipIslemleri();
            return islem.TipListele();
        }


    }
}
