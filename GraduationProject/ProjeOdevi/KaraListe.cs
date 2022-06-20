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
    public partial class KaraListe : Form
    {
        public KaraListe()
        {
            InitializeComponent();
            Listele();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);

            dataGridView1.Columns[0].HeaderText = "KaraListe Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 175;

            dataGridView1.Columns[1].HeaderText = "Müsteri Id";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.Columns[2].HeaderText = "Müsteri Ad";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 175;

            dataGridView1.Columns[3].HeaderText = "Müsteri Soyad";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 175;

            dataGridView1.Columns[4].HeaderText = "Sebeb / Gerekçe";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].MinimumWidth = 350;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("times new roman", 9, FontStyle.Bold);

        }

        public void Listele()
        {
            KaraListee k = new KaraListee();
            dataGridView1.DataSource = k.Listele();
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

        private void KaraListe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KaraListeIslemleri frm = new KaraListeIslemleri();
            frm.ShowDialog();
            Listele();
        }

        private void btnSilll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["KaraListeId"].Value);
                KaraListee karaliste = new KaraListee();
                karaliste.KaraListeId = id;
                karaliste.Sil();
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt seçin");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["KaraListeId"].Value);
                KaraListee u = new KaraListee();
                u.KaraListeId = id;
                u.Sil();
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt seçin");
            }
        }
    }
}
