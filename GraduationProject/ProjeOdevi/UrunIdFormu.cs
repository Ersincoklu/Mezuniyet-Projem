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
using System.Data;
using BLL;

namespace ProjeOdevi
{
    public partial class UrunIdFormu : Form
    {
        public UrunIdFormu()
        {
            InitializeComponent();

            Urun u = new Urun();
            dataGridView1.DataSource = u.UrunIdListeler();

            dataGridView1.Columns[0].HeaderText = "Ürün Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 110;

            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 105;
        }


    }
}
