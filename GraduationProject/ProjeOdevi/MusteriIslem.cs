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
    public partial class MusteriIslem : Form
    {
        public MusteriIslem()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database =DvdVcdOtomasyon;Integrated Security = true");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtTc.Text.Trim() != "" && txtCep.Text.Trim() != "" && txtMail.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtNot.Text.Trim() != "")
            if(GirdiKontrol())
            {
                Musteri m = new Musteri();
                m.MusteriAd = txtAd.Text;
                m.MusteriSoyad = txtSoyad.Text;
                m.MusteriTc = txtTc.Text;
                m.MusteriCepNo = txtCep.Text;
                m.MusteriCinsiyet = rbBay.Checked ? 'e' : 'k';
                m.MusteriMail = txtMail.Text;
                m.MusteriAdres = txtAdres.Text;
                if (cbAktif.Checked)
                    m.Aktif = true;
                else
                    m.Aktif = false;
                m.MusteriNot = txtNot.Text;
                MessageBox.Show("Ekleme yapmak istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (true)
                {
                    lblMsj.Text = m.MusteriEkle();
                }
                
            }
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            txtCep.Text = "";
            txtMail.Text = "";
            txtAdres.Text = "";
            txtNot.Text = "";
            //else
            //{
            //    MessageBox.Show("Müşteri eklerken boş alan bırakamazsınız");
            //}
        }

        #region Kontrol Alanı...
        private bool GirdiKontrol()
        {
            AdKontrol(); SoyadKontrol(); TcKontrol(); CebKontrol(); MailKontrol(); AdresKontrol(); NotKontrol();
            return (AdKontrol() && SoyadKontrol() && TcKontrol() && CebKontrol() && MailKontrol() && AdresKontrol() && NotKontrol());
        }

        private bool AdKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAd.Text))
            {
                errorProvider1.SetError(txtAd, "Müşteri Adı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAd, "");
                return true;
            }
        }

        private bool SoyadKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                errorProvider1.SetError(txtSoyad, "Müşteri soyadı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtSoyad, "");
                return true;
            }
        }

        private bool TcKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtTc.Text))
            {
                errorProvider1.SetError(txtTc, "Müşteri Tc no alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtTc, "");
                return true;
            }
        }

        private bool CebKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtCep.Text))
            {
                errorProvider1.SetError(txtCep, "Müşteri Cep no alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtCep, "");
                return true;
            }
        }

        private bool MailKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtMail.Text))
            {
                errorProvider1.SetError(txtMail, "Müşteri mail alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMail, "");
                return true;
            }
        }

        private bool AdresKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAdres.Text))
            {
                errorProvider1.SetError(txtAdres, "Müşteri Adres alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAdres, "");
                return true;
            }
        }

        private bool NotKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtNot.Text))
            {
                errorProvider1.SetError(txtNot, "Müşteri Not alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtNot, "");
                return true;
            }
        }
        #endregion
    }
}
