using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace ProjeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Formlar Arası Geçiş....
        private void toolStripCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void toolStripMusteriler_Click(object sender, EventArgs e)
        {
            MusterilerForm frm1 = new MusterilerForm();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void UrunDVD_Click(object sender, EventArgs e)
        {
            UrunlerDvd frm1 = new UrunlerDvd();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }
      

        private void UrunVCD_Click(object sender, EventArgs e)
        {
            UrunlerVcd frm1 = new UrunlerVcd();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        #endregion

        private void toolStripKiralik_Click(object sender, EventArgs e)
        {
            KiralikDvd frm1 = new KiralikDvd();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void MuhasebeHarcamalarOdemeler_Click(object sender, EventArgs e)
        {
            HarcamalarOdemeler frm1 = new HarcamalarOdemeler();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void MuhasebeKasalar_Click(object sender, EventArgs e)
        {
            Kasalar frm1 = new Kasalar();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void AraclarDövizCevirici_Click(object sender, EventArgs e)
        {
            DovizCevirme frm1 = new DovizCevirme();          
            frm1.Show();
        }

        private void AraclarKaraListe_Click(object sender, EventArgs e)
        {
            KaraListe frm1 = new KaraListe();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void Kullanicilar_Click(object sender, EventArgs e)
        {
            KullanicilarYonetim frm1 = new KullanicilarYonetim();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private void UrunSatis_Click(object sender, EventArgs e)
        {
            Satis frm1 = new Satis();
            frm1.MdiParent = this;
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        

        
    }
}
