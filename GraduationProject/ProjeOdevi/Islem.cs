using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DAL;

namespace ProjeOdevi
{
    public partial class Islem : Form
    {
        public Islem(int id)
        {
            InitializeComponent();
            if (id == 0)
            {
                txtId.Enabled = false;
            }
            else if (id == 1)
            {
                btnKaydet.Enabled = false;
            }
            
        }

        private void ComboboxListele()
        {
            cbTip.DataSource = new UrunTipIslemleri().TipListele();
            cbTip.DisplayMember = "UrunTipAd";
            cbTip.ValueMember = "UrunTipId";

            cbTur.DataSource = new UrunTurIslemleri().TurListele();
            cbTur.DisplayMember = "UrunTurAd";
            cbTur.ValueMember = "UrunTurId";

            cbKategori.DataSource = new UrunKategoriIslemleri().KategoriListele();
            cbKategori.DisplayMember = "UrunKategoriAd";
            cbKategori.ValueMember = "UrunKategoriId";
        }

        SqlConnection con = new SqlConnection("server=.;database =DvdVcdOtomasyon;Integrated Security = true");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
                Urun urun = new Urun();
                UrunTip tip = new UrunTip(Convert.ToInt32(cbTip.SelectedValue.ToString()));
                urun.UrunTip = tip;
                UrunTur tur = new UrunTur(Convert.ToInt32(cbTur.SelectedValue.ToString()));
                urun.UrunTur = tur;
                UrunKategori kat = new UrunKategori(Convert.ToInt32(cbKategori.SelectedValue.ToString()));
                urun.UrunKategori = kat;


                if(GirdiKontrol())
                {
                    urun.UrunKodu = Convert.ToInt32(txtKodu.Text);
                    urun.UrunAd = txtAdi.Text;
                    urun.UrunOzeti = txtOzeti.Text;
                    urun.UrunAlisFiyati = Convert.ToDecimal(txtAlis.Text);
                    urun.UrunSatisFiyati = Convert.ToDecimal(txtFiyati.Text);
                    urun.UrunAdet = Convert.ToInt32(txtAdet.Text);
                    lblMesaj.Text = urun.UrunEkle();
                    Islem frm = new Islem(0);

                    txtKodu.Text = "";
                    txtAdi.Text = "";
                    txtOzeti.Text = "";
                    txtAlis.Text = "";
                    txtFiyati.Text = "";
                    txtAdet.Text = "";
                }
              
        }

        private void Islem_Load(object sender, EventArgs e)
        {
            ComboboxListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        #region Girdi Kontrolleri...
        private bool GirdiKontrol()
        {
            KodKontrol(); AdKontrol(); AlisFiyatKontrol(); SatisFiyatKontrol(); AdetKontrol(); OzetKontrol();
            return (KodKontrol() && AdKontrol() && AlisFiyatKontrol() && SatisFiyatKontrol() && AdetKontrol() && OzetKontrol());
        }

        private bool KodKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtKodu.Text))
            {
                errorProvider1.SetError(txtKodu, "Ürün kodu alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtKodu, "");
                return true;
            }
        }

        private bool AdKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAdi.Text))
            {
                errorProvider1.SetError(txtAdi, "Ürün Adı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAdi, "");
                return true;
            }
        }

        private bool OzetKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtOzeti.Text))
            {
                errorProvider1.SetError(txtOzeti, "Ürün Özeti alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtOzeti, "");
                return true;
            }
        }

        private bool AlisFiyatKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAlis.Text))
            {
                errorProvider1.SetError(txtAlis, "Ürün Alış Fiyatı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAlis, "");
                return true;
            }
        }

        private bool SatisFiyatKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtFiyati.Text))
            {
                errorProvider1.SetError(txtFiyati, "Ürün satış fiyatı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtFiyati, "");
                return true;
            }
        }

        private bool AdetKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAdet.Text))
            {
                errorProvider1.SetError(txtAdet, "Ürün Adet alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAdet, "");
                return true;
            }
        }
        #endregion
    }
}
