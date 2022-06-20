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
    public partial class HarcamalarOdemeler : Form
    {
        public HarcamalarOdemeler()
        {
           
            InitializeComponent();
            Harcama h = new Harcama();
            dataGridView1.DataSource = h.Listele();

            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridViewDvd_CellFormatting);

            dataGridView1.Columns[0].HeaderText = "Harcama Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 110;

            dataGridView1.Columns[1].HeaderText = "Harcama'nın Adı";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 200;

            dataGridView1.Columns[2].HeaderText = "Harcama'nın Gerekçesi";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].MinimumWidth = 450;

            dataGridView1.Columns[3].HeaderText = "Harcama'nın Ücreti";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].MinimumWidth = 150;

            dataGridView1.Columns[4].HeaderText = "Harcama'nın Tarihi";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].MinimumWidth = 180;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("times new roman", 9, FontStyle.Bold);            
        }

        private void dataGridViewDvd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                //seçli satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionBackColor = Color.Green;
                //seçili satır yazı rengini beyaz yapıyoruz
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }   

        private void btnKaydetE_Click(object sender, EventArgs e)
        {
            if (txtGiderAdE.Text.Trim() != "" && txtGiderTarihE.Text.Trim()!= "" && txtGiderUcretE.Text.Trim() != "" && txtMetinE.Text.Trim() != "")
            {
                Harcama h = new Harcama();
                h.GiderAd = txtGiderAdE.Text;
                h.HarcamaTarih = Convert.ToDateTime(txtGiderTarihE.Text);
                h.Fiyat = Convert.ToInt32(txtGiderUcretE.Text);
                h.Metin = txtMetinE.Text;
                h.HarcamaEkle();
                dataGridView1.DataSource = h.Listele();
                txtGiderAdE.Text = "";
                txtGiderTarihE.Text = "";
                txtGiderUcretE.Text = "";
                txtMetinE.Text = "";
            }

            else
            {
                MessageBox.Show("Harcama eklerken boş alan bırakamazsınız..");
            }
        }

        private void HarcamalarOdemeler_Load(object sender, EventArgs e)
        {
            GuncellemeIslemi();
        }
        public void GuncellemeIslemi()
        {
            txtIdG.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdG.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMetinG.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUcretG.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTarihG.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
                Harcama h = new Harcama();
                h.HarcamaId = Convert.ToInt32(txtIdG.Text);
                h.GiderAd = txtAdG.Text;
                h.Metin = txtMetinG.Text;
                h.Fiyat = Convert.ToDecimal(txtUcretG.Text);
                h.HarcamaTarih = Convert.ToDateTime(txtTarihG.Text);
                h.HarcamaGuncelle();
                dataGridView1.DataSource = h.Listele();   
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GuncellemeIslemi();
        }
    }
}
