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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        
        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
           
           textBoxSifre.PasswordChar = (char)42;
        }

        private void buttonTamam_Click(object sender, EventArgs e)
        {

            Kullanici kk = new Kullanici();
            kk.kullaniciadi = textBoxKullaniciAdi.Text;
            kk.kullanicisifre = textBoxSifre.Text;
            if (kk.KullaniciGiris())
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                frm.Close();
            }

            else
            {
                labelMesaj.Text = "Kullanıcı adı veya şifresi hatalı";
            }

        }
        private void buttonIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
