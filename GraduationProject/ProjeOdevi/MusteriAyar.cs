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
    public partial class MusteriAyar : Form
    {
        int MusteriId = 0;
        public MusteriAyar(int musteriId)
        {
            InitializeComponent();
            MusteriId = musteriId;
        }


        SqlConnection con = new SqlConnection("server=.;database =DvdVcdOtomasyon;Integrated Security = true");

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            if (rbKaraListeEkle.Checked)
	        {
                string metin = textBox1.Text;
                
                musteri.KaraListeEkle(MusteriId, metin);
	        }
            else
	        {
                //musteri.KaraListeSil(MusteriId);
	        }
            
        }

        
    }
}
