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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            Listele();
            dataGridView1.Columns[0].HeaderText = "Ürün Satış Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 100;

            dataGridView1.Columns[1].HeaderText = "Ürün Id";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 100;


            dataGridView1.Columns[2].HeaderText = "Müşteri Id";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].MinimumWidth = 100;

            dataGridView1.Columns[3].HeaderText = "Kasa Id";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].MinimumWidth = 100;

            dataGridView1.Columns[4].HeaderText = "Ödeme Id";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].MinimumWidth = 100;

            dataGridView1.Columns[5].HeaderText = "Adet";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].MinimumWidth = 100;

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
            UrunSatiss k = new UrunSatiss();
            dataGridView1.DataSource = k.Listele();
        }
    }
}
