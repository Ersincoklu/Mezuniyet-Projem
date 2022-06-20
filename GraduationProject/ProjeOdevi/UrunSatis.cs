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
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        public void ComboboxListele()
        {
            cbOdeme.DataSource = new Odeme().Listele();
            cbOdeme.DisplayMember = "OdemeTipi";
            cbOdeme.ValueMember = "OdemeID";

            cbKasa.DataSource = new Kasa().Listele();
            cbKasa.DisplayMember = "KasaAd";
            cbKasa.ValueMember = "KasaId";

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            
            UrunSatiss satis = new UrunSatiss();
            satis.UrunId.UrunId = Convert.ToInt32(txtUrunId.Text.ToString());
            satis.MusteriId.MusteriId = Convert.ToInt32(txtMusteriId.Text.ToString());
            //txtUrunId.Text = Convert.ToInt32(satis.UrunId).ToString() ;
            //txtMusteriId.Text =Convert.ToInt32(satis.MusteriId.MusteriId).ToString();

            Kasa kasa = new Kasa(Convert.ToInt32(cbKasa.SelectedValue.ToString()));
            satis.KasaId = kasa;

            Odeme odeme = new Odeme(Convert.ToInt32(cbOdeme.SelectedValue.ToString()));
            satis.OdemeId = odeme;

            try
            {
                lblMsj.Text = satis.UrunSatisEkle();
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message); 
            }
            this.Close();
        }

        private void UrunSatis_Load(object sender, EventArgs e)
        {
            ComboboxListele();
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
    }
}
