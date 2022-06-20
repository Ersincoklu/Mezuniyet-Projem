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
    public partial class KiralikDvd : Form
    {
        private SqlConnection con = new SqlConnection("server=.;database =DvdVcdOtomasyon;Integrated Security = true");
        public KiralikDvd()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            Listele();

            dataGridView1.Columns[0].HeaderText = "Kira Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 110;

            dataGridView1.Columns[1].HeaderText = "Ürün Id";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 110;

            dataGridView1.Columns[2].HeaderText = "Urun Tipi";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].MinimumWidth = 110;

            dataGridView1.Columns[3].HeaderText = "Ürün Türü ";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].MinimumWidth = 110;

            dataGridView1.Columns[4].HeaderText = "Müsteri Adı";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].MinimumWidth = 125;

            dataGridView1.Columns[5].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].MinimumWidth = 135;

            dataGridView1.Columns[6].HeaderText = "Kira Bedeli";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].MinimumWidth = 140;

            dataGridView1.Columns[7].HeaderText = "Kira Başlangıç Tarihi";
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].MinimumWidth = 190;

            dataGridView1.Columns[8].HeaderText = "Kira Bitiş Tarihi";
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].MinimumWidth = 190;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("times new roman", 9, FontStyle.Bold);
        }

        private void KiralikDvdFilmler_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();

            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                //seçli satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionBackColor = Color.Green;
                //seçili satır yazı rengini beyaz yapıyoruz
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }


        private void btnSilll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["KiraId"].Value);
                UrunKiralama k = new UrunKiralama();
                k.UrunKiralamaId = id;
                k.KiraSil();
                dataGridView1.DataSource = k.KiraListele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KiraIslem frm = new KiraIslem(0);
            frm.ShowDialog();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KiraIslem frm = new KiraIslem(1);
            frm.ShowDialog();
            Listele();
        }

        public void Listele()
        {
            UrunKiralama k = new UrunKiralama();
            dataGridView1.DataSource = k.KiraListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = "SELECT * FROM Kira WHERE UrunId LIKE'" + txtAra.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(ara, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


    }
}
