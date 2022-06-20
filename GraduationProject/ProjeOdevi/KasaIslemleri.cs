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
    public partial class KasaIslemleri : Form
    {
        public KasaIslemleri(int id)
        {
            InitializeComponent();
            if (id == 0)
            {
                txtId.Enabled = false;
                btnGuncelle.Enabled = false;
            }
            else if (id == 1)
            {
                txtId.Enabled = true;
                btnEkle.Enabled = false;
            }
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kasa k = new Kasa();
            k.KasaAd = txtAd.Text;
            lblMesaj.Text = k.KasaEkle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kasa k = new Kasa();
            k.KasaId = Convert.ToInt32(txtId.Text);
            k.KasaAd = txtAd.Text;
            lblMesaj.Text = k.KasaGuncelle();
        }
    }
}
