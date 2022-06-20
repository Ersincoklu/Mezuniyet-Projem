namespace ProjeOdevi
{
    partial class UrunlerDvd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunlerDvd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.rbOyunlar = new System.Windows.Forms.RadioButton();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.dataGridViewDvd = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtOzet = new System.Windows.Forms.RichTextBox();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.toolStripEkleSilGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDvd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMüzikler
            // 
            this.rbMüzikler.AutoSize = true;
            this.rbMüzikler.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbMüzikler.Location = new System.Drawing.Point(449, 3);
            this.rbMüzikler.Name = "rbMüzikler";
            this.rbMüzikler.Size = new System.Drawing.Size(64, 17);
            this.rbMüzikler.TabIndex = 31;
            this.rbMüzikler.TabStop = true;
            this.rbMüzikler.Text = "Müzikler";
            this.rbMüzikler.UseVisualStyleBackColor = false;
            this.rbMüzikler.CheckedChanged += new System.EventHandler(this.rbMüzikler_CheckedChanged);
            // 
            // rbFilmler
            // 
            this.rbFilmler.AutoSize = true;
            this.rbFilmler.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbFilmler.Location = new System.Drawing.Point(389, 3);
            this.rbFilmler.Name = "rbFilmler";
            this.rbFilmler.Size = new System.Drawing.Size(54, 17);
            this.rbFilmler.TabIndex = 32;
            this.rbFilmler.TabStop = true;
            this.rbFilmler.Text = "Filmler";
            this.rbFilmler.UseVisualStyleBackColor = false;
            this.rbFilmler.CheckedChanged += new System.EventHandler(this.rbFilmler_CheckedChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(158, 2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(163, 20);
            this.txtAra.TabIndex = 30;
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
            this.toolStripEkleSilGuncelle.TabIndex = 29;
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
            // rbOyunlar
            // 
            this.rbOyunlar.AutoSize = true;
            this.rbOyunlar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbOyunlar.Location = new System.Drawing.Point(519, 3);
            this.rbOyunlar.Name = "rbOyunlar";
            this.rbOyunlar.Size = new System.Drawing.Size(61, 17);
            this.rbOyunlar.TabIndex = 33;
            this.rbOyunlar.TabStop = true;
            this.rbOyunlar.Text = "Oyunlar";
            this.rbOyunlar.UseVisualStyleBackColor = false;
            this.rbOyunlar.CheckedChanged += new System.EventHandler(this.rbOyunlar_CheckedChanged);
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rbHepsi.Checked = true;
            this.rbHepsi.Location = new System.Drawing.Point(331, 3);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(52, 17);
            this.rbHepsi.TabIndex = 34;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = false;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // dataGridViewDvd
            // 
            this.dataGridViewDvd.AllowUserToAddRows = false;
            this.dataGridViewDvd.AllowUserToDeleteRows = false;
            this.dataGridViewDvd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewDvd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDvd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDvd.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewDvd.MultiSelect = false;
            this.dataGridViewDvd.Name = "dataGridViewDvd";
            this.dataGridViewDvd.RowHeadersVisible = false;
            this.dataGridViewDvd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDvd.Size = new System.Drawing.Size(1365, 540);
            this.dataGridViewDvd.TabIndex = 35;
            this.dataGridViewDvd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDvd_CellClick);
            this.dataGridViewDvd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDvd_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tipi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Kodu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1024, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Özeti :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Alış Fiyatı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(787, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Satış Fiyatı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(924, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Adet :";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(111, 569);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(60, 21);
            this.cbTip.TabIndex = 39;
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(209, 569);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(65, 21);
            this.cbTur.TabIndex = 40;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(334, 569);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(70, 21);
            this.cbKategori.TabIndex = 41;
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(450, 569);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(85, 20);
            this.txtKodu.TabIndex = 42;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(570, 569);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(85, 20);
            this.txtAdi.TabIndex = 43;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(1062, 569);
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(229, 47);
            this.txtOzet.TabIndex = 44;
            this.txtOzet.Text = "";
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(721, 569);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(60, 20);
            this.txtAlis.TabIndex = 45;
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(851, 569);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(65, 20);
            this.txtFiyati.TabIndex = 46;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(955, 569);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(60, 20);
            this.txtAdet.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1297, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(24, 569);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 38;
            // 
            // UrunlerDvd
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
            this.Controls.Add(this.dataGridViewDvd);
            this.Controls.Add(this.rbHepsi);
            this.Controls.Add(this.rbOyunlar);
            this.Controls.Add(this.rbMüzikler);
            this.Controls.Add(this.rbFilmler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.toolStripEkleSilGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunlerDvd";
            this.Text = "UrunlerDvd";
            this.Load += new System.EventHandler(this.UrunlerDvd_Load);
            this.toolStripEkleSilGuncelle.ResumeLayout(false);
            this.toolStripEkleSilGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDvd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.RadioButton rbOyunlar;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.DataGridView dataGridViewDvd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.RichTextBox txtOzet;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.TextBox txtFiyati;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}