using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BLL;
using DAL;

namespace ProjeOdevi
{
    public partial class UrunlerDvd : Form
    {
        public UrunlerDvd()
        {
            InitializeComponent();
            dataGridViewDvd.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridViewDvd_CellFormatting);
            Ara();

            dataGridViewDvd.Columns[0].HeaderText = "Ürün Id";
            dataGridViewDvd.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[0].Width = 110; 

            dataGridViewDvd.Columns[1].HeaderText = "Ürün Tipi";
            dataGridViewDvd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[1].Width = 105;
            
            
            dataGridViewDvd.Columns[2].HeaderText = "Ürün Kodu";
            dataGridViewDvd.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[2].MinimumWidth = 150;

            dataGridViewDvd.Columns[3].HeaderText = "Ürün Adı";
            dataGridViewDvd.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[3].MinimumWidth = 215;

            dataGridViewDvd.Columns[4].HeaderText = "Ürün Özeti";
            dataGridViewDvd.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[4].MinimumWidth = 370;

            dataGridViewDvd.Columns[5].HeaderText = "Ürün Alış Fiyatı";
            dataGridViewDvd.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[5].MinimumWidth = 125;

            dataGridViewDvd.Columns[6].HeaderText = "Ürün Satış Fiyatı";
            dataGridViewDvd.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[6].MinimumWidth = 125;

            dataGridViewDvd.Columns[7].HeaderText = "Adet";
            dataGridViewDvd.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDvd.Columns[7].MinimumWidth = 85;

            dataGridViewDvd.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("times new roman", 9, FontStyle.Bold);
             
        }

        private void dataGridViewDvd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewDvd.Rows[e.RowIndex].Selected)
            {
                //seçli satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionBackColor = Color.Green;
                //seçili satır yazı rengini beyaz yapıyoruz
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }   

        private void UrunlerDvd_Load(object sender, EventArgs e)
        {
            ComboboxListele();
        }      

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void rbFilmler_CheckedChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void rbMüzikler_CheckedChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void rbOyunlar_CheckedChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Ara();
        }

        private void Ara()
        {
            Urun u = new Urun();
            int urunTurId = 0;
            if (rbFilmler.Checked)
	        {
                urunTurId = 30;
	        }
            if (rbMüzikler.Checked)
	        {
                urunTurId = 31;
	        }
            if (rbOyunlar.Checked)
	        {
                urunTurId = 32;
	        }
            dataGridViewDvd.DataSource = u.UrunListele(20, txtAra.Text, urunTurId); // Dvd = 20
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewDvd.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewDvd.SelectedRows[0].Cells["UrunId"].Value);
                Urun u = new Urun();
                u.UrunId = id;
                u.UrunSil();
                Ara();
            }
            else
            {
                MessageBox.Show("Kayıt seçin");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem(1);
            islem.ShowDialog();
            Ara();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem(0);
            islem.ShowDialog();
            Ara();
        }

        private void dataGridViewDvd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UrunSatis detay = new UrunSatis();
            detay.ShowDialog();
            Ara();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem(1);
            islem.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtId.Text.Trim() != "" && txtKodu.Text.Trim() != "" && txtAdi.Text.Trim() != "" && txtOzet.Text.Trim() != "" && txtAlis.Text.Trim() != "" && txtFiyati.Text.Trim() != "" && txtAdet.Text.Trim() != "")
            if(GirdiKontrol())
            {
                Urun urun = new Urun();
                urun.UrunId = Convert.ToInt32(txtId.Text);
                UrunTip tip = new UrunTip(Convert.ToInt32(cbTip.SelectedValue.ToString()));
                urun.UrunTip = tip;
                UrunTur tur = new UrunTur(Convert.ToInt32(cbTur.SelectedValue.ToString()));
                urun.UrunTur = tur;
                UrunKategori kat = new UrunKategori(Convert.ToInt32(cbKategori.SelectedValue.ToString()));

                urun.UrunKategori = kat;
                urun.UrunId = Convert.ToInt32(txtId.Text);
                urun.UrunKodu = Convert.ToInt32(txtKodu.Text);
                urun.UrunAd = txtAdi.Text;
                urun.UrunOzeti = txtOzet.Text;
                urun.UrunAlisFiyati = Convert.ToDecimal(txtAlis.Text);
                urun.UrunSatisFiyati = Convert.ToDecimal(txtFiyati.Text);
                urun.UrunAdet = Convert.ToInt32(txtAdet.Text);
                MessageBox.Show("Ürünü güncellemek istediğinizden eminmisiniz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (true)
                {
                    MessageBox.Show(urun.UrunGuncelle());
                }
                Ara();
            }
            //else
            //{
            //    MessageBox.Show("Lütfen boş alanları doldurunuz...");
            //}
        }
        public void Aktar()
        {
            ComboboxListele();
            txtId.Text = dataGridViewDvd.CurrentRow.Cells[0].Value.ToString();
            //cbTip.SelectedItem = dataGridViewDvd.CurrentRow.Cells[1].Value.ToString();
            //cbTur.SelectedText = dataGridViewDvd.CurrentRow.Cells[2].Value.ToString();
            // cbKategori.Text = dataGridViewDvd.CurrentRow.Cells[3].Value.ToString();
            txtKodu.Text = dataGridViewDvd.CurrentRow.Cells[2].Value.ToString();
            txtAdi.Text = dataGridViewDvd.CurrentRow.Cells[3].Value.ToString();
            txtAlis.Text = dataGridViewDvd.CurrentRow.Cells[5].Value.ToString();
            txtFiyati.Text = dataGridViewDvd.CurrentRow.Cells[6].Value.ToString();
            txtAdet.Text = dataGridViewDvd.CurrentRow.Cells[7].Value.ToString();
            txtOzet.Text = dataGridViewDvd.CurrentRow.Cells[4].Value.ToString();
        }

        private void ComboboxListele()
        {
            cbTip.DataSource = new UrunTipIslemleri().TipListele();
            cbTip.DisplayMember = "UrunTipAd";
            cbTip.ValueMember = "UrunTipId";

            cbTur.DataSource = new UrunTurIslemleri().TurListele();
            cbTur.DisplayMember = "UrunTurAd";
            cbTur.ValueMember = "UrunTurId";

            cbKategori.DataSource = new UrunKategoriIslemleri().KategoriListele();
            cbKategori.DisplayMember = "UrunKategoriAd";
            cbKategori.ValueMember = "UrunKategoriId";
        }

        private void dataGridViewDvd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        #region Girdi Kontrolleri...
        private bool GirdiKontrol()
        {
            KodKontrol(); AdKontrol(); AlisFiyatKontrol(); SatisFiyatKontrol(); AdetKontrol(); OzetKontrol();
            return (KodKontrol() && AdKontrol() && AlisFiyatKontrol() && SatisFiyatKontrol() && AdetKontrol() && OzetKontrol());
        }

        private bool KodKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtKodu.Text))
            {
                errorProvider1.SetError(txtKodu, "Ürün kodu alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtKodu, "");
                return true;
            }
        }

        private bool AdKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAdi.Text))
            {
                errorProvider1.SetError(txtAdi, "Ürün Adı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAdi, "");
                return true;
            }
        }

        private bool OzetKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtOzet.Text))
            {
                errorProvider1.SetError(txtOzet, "Ürün Özeti alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtOzet, "");
                return true;
            }
        }

        private bool AlisFiyatKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAlis.Text))
            {
                errorProvider1.SetError(txtAlis, "Ürün Alış Fiyatı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAlis, "");
                return true;
            }
        }

        private bool SatisFiyatKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtFiyati.Text))
            {
                errorProvider1.SetError(txtFiyati, "Ürün satış fiyatı alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtFiyati, "");
                return true;
            }
        }

        private bool AdetKontrol()
        {
            if (String.IsNullOrWhiteSpace(txtAdet.Text))
            {
                errorProvider1.SetError(txtAdet, "Ürün Adet alanı boş geçilemez!!!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAdet, "");
                return true;
            }
        }
        #endregion
    }
 }

