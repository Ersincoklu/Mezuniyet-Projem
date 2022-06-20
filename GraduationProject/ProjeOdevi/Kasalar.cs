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
    public partial class Kasalar : Form
    {
        public Kasalar()
        {
            InitializeComponent();
            Listele();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);

            dataGridView1.Columns[0].HeaderText = "Kasa Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 100;

            dataGridView1.Columns[1].HeaderText = "Kasa Adı";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 200;


            dataGridView1.Columns[2].HeaderText = "Aktif";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].MinimumWidth = 100;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("times new roman", 9, FontStyle.Bold);
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

        public void Listele()
        {
            Kasa k = new Kasa();
            dataGridView1.DataSource = k.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KasaIslemleri frm = new KasaIslemleri(0);
            frm.ShowDialog();
            Listele();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["KasaId"].Value);
                Kasa k = new Kasa();
                k.KasaId = id;
                k.KasaSil();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KasaIslemleri frm = new KasaIslemleri(1);
            frm.ShowDialog();
            Listele();
        }
    }
}
