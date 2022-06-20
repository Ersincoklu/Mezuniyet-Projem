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

namespace ProjeOdevi
{
    public partial class KullaniciYonetimIslemleri : Form
    {
        public KullaniciYonetimIslemleri(int id)
        {
            InitializeComponent();

            if (id == 0)
            {
                txtId.Enabled = false;
                lblMsj.Text = "Ekle";
                btnGuncelle.Enabled = false;

            }

            else if (id == 1)
            {
                lblMsj.Text = "Guncelle";
                btnEkle.Enabled = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.kullaniciadi = txtAd.Text;
            kullanici.kullanicisifre = txtSifre.Text;
            lblMsj.Text = kullanici.KullaniciEkle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.kullaniciid = Convert.ToInt32(txtId.Text);
            kullanici.kullaniciadi = txtAd.Text;
            kullanici.kullanicisifre = txtSifre.Text;
            lblMsj.Text = kullanici.KullaniciGuncelle();
        }
    }
}
