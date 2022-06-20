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
using DAL;
using BLL;

namespace ProjeOdevi
{
    public partial class KiraIslem : Form
    {
        public KiraIslem(int id)
        {
            InitializeComponent();
            if (id == 0)
            {
                txtId.Enabled = false;
                
            }
            else if (id == 1)
            {
                btnEkle.Enabled = false;
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

            
        }

        private void KiraIslem_Load(object sender, EventArgs e)
        {
            ComboboxListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunKiralama urun = new UrunKiralama();
            urun.UrunKiralamaId = Convert.ToInt32(txtId.Text);
            UrunTip tip = new UrunTip(Convert.ToInt32(cbTip.SelectedValue.ToString()));
            urun.UrunTip = tip;
            UrunTur tur = new UrunTur(Convert.ToInt32(cbTur.SelectedValue.ToString()));
            urun.UrunTur = tur;

            urun.UrunId = new Urun();
            urun.UrunId.UrunId = Convert.ToInt32(txtUrunId.Text);
            urun.MusteriId = new Musteri();
            urun.MusteriId.MusteriId = Convert.ToInt32(txtMusteriId.Text);
            urun.UrunKiraBedeli = Convert.ToDecimal(txtKiraBedeli.Text);
            urun.UrunBaslangicTarih = Convert.ToDateTime(txtKiraBaslangic.Text);
            urun.UrunBitisTarih = Convert.ToDateTime(txtKiraBitis.Text);
            lblMsj.Text = urun.KiraGuncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (GirdiKontrol())
            {
                UrunKiralama urun = new UrunKiralama();
                UrunTip tip = new UrunTip(Convert.ToInt32(cbTip.SelectedValue.ToString()));
                urun.UrunTip = tip;
                UrunTur tur = new UrunTur(Convert.ToInt32(cbTur.SelectedValue.ToString()));
                urun.UrunTur = tur;

                urun.UrunId = new Urun();
                urun.UrunId.UrunId = Convert.ToInt32(txtUrunId.Text);
                urun.MusteriId = new Musteri();
                urun.MusteriId.MusteriId = Convert.ToInt32(txtMusteriId.Text);
                urun.UrunKiraBedeli = Convert.ToDecimal(txtKiraBedeli.Text);
                urun.UrunBaslangicTarih = Convert.ToDateTime(txtKiraBaslangic.Text);
                urun.UrunBitisTarih = Convert.ToDateTime(txtKiraBitis.Text);
                lblMsj.Text = urun.KiraEkle();
            }

            txtUrunId.Text = "";
            txtMusteriId.Text = "";
            txtKiraBedeli.Text = "";
            txtKiraBaslangic.Text = "";
            txtKiraBitis.Text = "";
        }

        private void btnUrunId_Click(object sender, EventArgs e)
        {
            UrunIdFormu frm = new UrunIdFormu();
            frm.ShowDialog();
        }

        private void btnMusteriId_Click(object sender, EventArgs e)
        {
            MusteriIdFormu frm = new MusteriIdFormu();
            frm.ShowDialog();
        }


        private bool GirdiKontrol()
        {
            UrunIdKontrol(); MusteriIdKontrol(); KiraBedeliKontrol(); KiraBaslangicKontrol(); KiraBitisKontrol();
            return (UrunIdKontrol() && MusteriIdKontrol() && KiraBedeliKontrol() && KiraBaslangicKontrol() &&  KiraBitisKontrol());
        }

        private bool UrunIdKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtUrunId.Text))
            {
                errorProvider1.SetError(txtUrunId, "Ürün Id alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtUrunId, "");
                return true;
            }
        }

        private bool MusteriIdKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtMusteriId.Text))
            {
                errorProvider1.SetError(txtMusteriId, "Müşteri Id alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMusteriId, "");
                return true;
            }
        }

        private bool KiraBedeliKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtKiraBedeli.Text))
            {
                errorProvider1.SetError(txtKiraBedeli, "Kira bedeli alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtKiraBedeli, "");
                return true;
            }
        }

        private bool KiraBaslangicKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtKiraBaslangic.Text))
            {
                errorProvider1.SetError(txtKiraBaslangic, "Kira başlangıç Fiyatı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtKiraBaslangic, "");
                return true;
            }
        }

        private bool KiraBitisKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtKiraBitis.Text))
            {
                errorProvider1.SetError(txtKiraBitis, "Kira bitiş  alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtKiraBitis, "");
                return true;
            }
        }
    }
}
