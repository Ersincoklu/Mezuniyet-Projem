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
    public partial class MusteriIdFormu : Form
    {
        public MusteriIdFormu()
        {
            InitializeComponent();

            Musteri u = new Musteri();
            dataGridView1.DataSource = u.musteriIdListele();

            dataGridView1.Columns[0].HeaderText = "Musteri Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 110;

            dataGridView1.Columns[1].HeaderText = "Musteri Adı";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 105;

            dataGridView1.Columns[2].HeaderText = "Musteri Soyadı";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 105;
        }
    }
}
