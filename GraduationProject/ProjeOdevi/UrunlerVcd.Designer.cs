namespace ProjeOdevi
{
    partial class UrunlerVcd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunlerVcd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.rbOyunlar = new System.Windows.Forms.RadioButton();
            this.rbMüzikler = new System.Windows.Forms.RadioButton();
            this.rbFilmler = new System.Windows.Forms.RadioButton();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.toolStripEkleSilGuncelle = new System.Windows.Forms.ToolStrip();
            this.btnEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTarih = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewVcd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.txtOzet = new System.Windows.Forms.RichTextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripEkleSilGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVcd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbHepsi.Checked = true;
            this.rbHepsi.Location = new System.Drawing.Point(336, 3);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(52, 17);
            this.rbHepsi.TabIndex = 41;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = false;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged_1);
            // 
            // rbOyunlar
            // 
            this.rbOyunlar.AutoSize = true;
            this.rbOyunlar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbOyunlar.Location = new System.Drawing.Point(524, 3);
            this.rbOyunlar.Name = "rbOyunlar";
            this.rbOyunlar.Size = new System.Drawing.Size(61, 17);
            this.rbOyunlar.TabIndex = 40;
            this.rbOyunlar.TabStop = true;
            this.rbOyunlar.Text = "Oyunlar";
            this.rbOyunlar.UseVisualStyleBackColor = false;
            this.rbOyunlar.CheckedChanged += new System.EventHandler(this.rbOyunlar_CheckedChanged);
            // 
            // rbMüzikler
            // 
            this.rbMüzikler.AutoSize = true;
            this.rbMüzikler.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbMüzikler.Location = new System.Drawing.Point(454, 3);
            this.rbMüzikler.Name = "rbMüzikler";
            this.rbMüzikler.Size = new System.Drawing.Size(64, 17);
            this.rbMüzikler.TabIndex = 38;
            this.rbMüzikler.TabStop = true;
            this.rbMüzikler.Text = "Müzikler";
            this.rbMüzikler.UseVisualStyleBackColor = false;
            this.rbMüzikler.CheckedChanged += new System.EventHandler(this.rbMüzikler_CheckedChanged);
            // 
            // rbFilmler
            // 
            this.rbFilmler.AutoSize = true;
            this.rbFilmler.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbFilmler.Location = new System.Drawing.Point(394, 3);
            this.rbFilmler.Name = "rbFilmler";
            this.rbFilmler.Size = new System.Drawing.Size(54, 17);
            this.rbFilmler.TabIndex = 39;
            this.rbFilmler.TabStop = true;
            this.rbFilmler.Text = "Filmler";
            this.rbFilmler.UseVisualStyleBackColor = false;
            this.rbFilmler.CheckedChanged += new System.EventHandler(this.rbFilmler_CheckedChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(159, 2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(163, 20);
            this.txtAra.TabIndex = 37;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // toolStripEkleSilGuncelle
            // 
            this.toolStripEkleSilGuncelle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkle,
            this.toolStripSeparator2,
            this.btnSil,
            this.toolStripSeparator4,
            this.lblTarih,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStripEkleSilGuncelle.Location = new System.Drawing.Point(0, 0);
            this.toolStripEkleSilGuncelle.Name = "toolStripEkleSilGuncelle";
            this.toolStripEkleSilGuncelle.Size = new System.Drawing.Size(1386, 25);
            this.toolStripEkleSilGuncelle.TabIndex = 36;
            // 
            // btnEkle
            // 
            this.btnEkle.AutoSize = false;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(57, 22);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = false;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTarih
            // 
            this.lblTarih.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(193, 22);
            this.toolStripLabel1.Text = "Teknik Destek Hattı : 0850 455 12 17";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel2.Text = "Ara : ";
            // 
            // dataGridViewVcd
            // 
            this.dataGridViewVcd.AllowUserToAddRows = false;
            this.dataGridViewVcd.AllowUserToDeleteRows = false;
            this.dataGridViewVcd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewVcd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVcd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewVcd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVcd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewVcd.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewVcd.Name = "dataGridViewVcd";
            this.dataGridViewVcd.RowHeadersVisible = false;
            this.dataGridViewVcd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVcd.Size = new System.Drawing.Size(1386, 540);
            this.dataGridViewVcd.TabIndex = 42;
            this.dataGridViewVcd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVcd_CellClick);
            this.dataGridViewVcd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVcd_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1297, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(955, 569);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(60, 20);
            this.txtAdet.TabIndex = 68;
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(851, 569);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(65, 20);
            this.txtFiyati.TabIndex = 67;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(721, 569);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(60, 20);
            this.txtAlis.TabIndex = 66;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(1062, 569);
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(229, 47);
            this.txtOzet.TabIndex = 65;
            this.txtOzet.Text = "";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(570, 569);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(85, 20);
            this.txtAdi.TabIndex = 64;
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(450, 569);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(85, 20);
            this.txtKodu.TabIndex = 63;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(334, 569);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(70, 21);
            this.cbKategori.TabIndex = 62;
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(209, 569);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(65, 21);
            this.cbTur.TabIndex = 61;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(111, 569);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(60, 21);
            this.cbTip.TabIndex = 60;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(24, 569);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(924, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Adet :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(787, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Satış Fiyatı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Alış Fiyatı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1024, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Özeti :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Kodu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tipi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Id :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UrunlerVcd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtFiyati);
            this.Controls.Add(this.txtAlis);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVcd);
            this.Controls.Add(this.rbHepsi);
            this.Controls.Add(this.rbOyunlar);
            this.Controls.Add(this.rbMüzikler);
            this.Controls.Add(this.rbFilmler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.toolStripEkleSilGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunlerVcd";
            this.Text = "UrunlerVcd";
            this.Load += new System.EventHandler(this.UrunlerVcd_Load);
            this.toolStripEkleSilGuncelle.ResumeLayout(false);
            this.toolStripEkleSilGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVcd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.RadioButton rbOyunlar;
        private System.Windows.Forms.RadioButton rbMüzikler;
        private System.Windows.Forms.RadioButton rbFilmler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ToolStrip toolStripEkleSilGuncelle;
        private System.Windows.Forms.ToolStripButton btnEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblTarih;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dataGridViewVcd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyati;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.RichTextBox txtOzet;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}