using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class DovizCevirme : Form
    {//Ersin ÇOKLU
        public DovizCevirme()
        {
            InitializeComponent();
        }

        double tl, dolar, euro;

        private void btnTL_Click(object sender, EventArgs e)
        {
            tl = Convert.ToDouble(txtTL.Text);
            dolar = tl / 2.51;
            txtDolar.Text = dolar.ToString("0.##");

            euro = tl / 2.92;
            txtEuro.Text = euro.ToString("0.##");
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            euro = Convert.ToDouble(txtEuro.Text);
            tl = euro * 2.92;
            txtTL.Text = tl.ToString("0.##");

            dolar = euro * 1.44;
            txtDolar.Text = dolar.ToString("0.##");
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            dolar = Convert.ToDouble(txtDolar.Text);
            tl = dolar * 2.51;
            txtTL.Text = tl.ToString("0.##");

            euro = dolar / 1.44;
            txtEuro.Text = euro.ToString("0.##");
        }

        private void DovizCevirme_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

    }
}
