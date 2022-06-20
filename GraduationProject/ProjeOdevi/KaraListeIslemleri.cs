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
    public partial class KaraListeIslemleri : Form
    {
        public KaraListeIslemleri()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KaraListee kara = new KaraListee();
            kara.MusteriId = new Musteri();
            kara.MusteriId.MusteriId = Convert.ToInt32(txtMusteri.Text);
            kara.Metin = txtSebeb.Text;
            lblMesaj.Text = kara.Ekle();
        }
    }
}
