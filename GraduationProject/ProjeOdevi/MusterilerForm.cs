using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;
using System.Data.Sql;

namespace ProjeOdevi
{
    public partial class MusterilerForm : Form
    {

        private SqlConnection con = new SqlConnection("server=.;database =DvdVcdOtomasyon;Integrated Security = true");

        public MusterilerForm()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            Ara();

            dataGridView1.Columns[0].HeaderText = "Müşteri Id";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 90;

            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 110;

            dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].MinimumWidth = 130;

            dataGridView1.Columns[3].HeaderText = "Müşteri Tc No";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].MinimumWidth = 150;

            dataGridView1.Columns[4].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].MinimumWidth = 140;

            dataGridView1.Columns[5].HeaderText = "Cinsiyeti";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].MinimumWidth = 40;

            dataGridView1.Columns[6].HeaderText = "Mail Adresi";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].MinimumWidth = 130;

            dataGridView1.Columns[7].HeaderText = "Müşteri Adresi";
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].MinimumWidth = 130;

            dataGridView1.Columns[8].HeaderText = "Müşteri Not";
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].MinimumWidth = 280;

            dataGridView1.Columns[9].HeaderText = "Aktif";
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].MinimumWidth = 50;

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

        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            Ara();
            lblTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void rbPasif_CheckedChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void Ara()
        {
            Musteri m = new Musteri();
            dataGridView1.DataSource = m.MusteriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriIslem frm = new MusteriIslem();
            frm.ShowDialog();
            Ara();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MusteriId"].Value);
                Musteri m = new Musteri();
                m.MusteriId = id;
                m.MusteriSil();
                Ara();
            }
            else
            {
                MessageBox.Show("Kayıt seçin");
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = "SELECT * FROM Musteri WHERE MusteriAd LIKE'" + txtAra.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(ara, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MusteriId"].Value);
                MusteriAyar ayar = new MusteriAyar(id);
                ayar.ShowDialog();
                Ara();
            }
        }

        public void Aktar()
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCeb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtNot.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (GirdiKontrol())
            {
                Musteri m = new Musteri();
                m.MusteriAd = txtAd.Text;
                m.MusteriSoyad = txtSoyad.Text;
                m.MusteriTc = txtTc.Text;
                m.MusteriCepNo = txtCeb.Text;
                m.MusteriCinsiyet = rbBay.Checked ? 'e' : 'k';
                m.MusteriMail = txtMail.Text;
                m.MusteriAdres = txtAdres.Text;
                if (cbAktif.Checked)
                    m.Aktif = true;
                else
                    m.Aktif = false;
                m.MusteriNot = txtNot.Text;
                MessageBox.Show("Güncellemek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (true)
                {
                   MessageBox.Show(m.MusteriGuncelle());
                }

                Ara();
            }
        }
           
        #region Kontrol Alanı...
        private bool GirdiKontrol()
        {
            AdKontrol(); SoyadKontrol(); TcKontrol(); CebKontrol(); MailKontrol(); AdresKontrol(); NotKontrol();
            return (AdKontrol() && SoyadKontrol() && TcKontrol() && CebKontrol() && MailKontrol() && AdresKontrol() && NotKontrol());
        }

        private bool AdKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAd.Text))
            {
                errorProvider1.SetError(txtAd, "Müşteri Adı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAd, "");
                return true;
            }
        }

        private bool SoyadKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                errorProvider1.SetError(txtSoyad, "Müşteri soyadı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtSoyad, "");
                return true;
            }
        }

        private bool TcKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtTc.Text))
            {
                errorProvider1.SetError(txtTc, "Müşteri Tc no alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtTc, "");
                return true;
            }
        }

        private bool CebKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtCeb.Text))
            {
                errorProvider1.SetError(txtCeb, "Müşteri Cep no alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtCeb, "");
                return true;
            }
        }

        private bool MailKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtMail.Text))
            {
                errorProvider1.SetError(txtMail, "Müşteri mail alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMail, "");
                return true;
            }
        }

        private bool AdresKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAdres.Text))
            {
                errorProvider1.SetError(txtAdres, "Müşteri Adres alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAdres, "");
                return true;
            }
        }

        private bool NotKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtNot.Text))
            {
                errorProvider1.SetError(txtNot, "Müşteri Not alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtNot, "");
                return true;
            }
        }
        #endregion

        }
    }

