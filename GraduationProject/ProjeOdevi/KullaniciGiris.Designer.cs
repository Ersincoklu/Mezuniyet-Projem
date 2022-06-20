namespace ProjeOdevi
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonTamam = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.labelMesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(199, 40);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(231, 20);
            this.textBoxKullaniciAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre : ";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(199, 64);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(231, 20);
            this.textBoxSifre.TabIndex = 4;
            // 
            // buttonTamam
            // 
            this.buttonTamam.BackColor = System.Drawing.SystemColors.Window;
            this.buttonTamam.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.buttonTamam.FlatAppearance.BorderSize = 0;
            this.buttonTamam.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.buttonTamam.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.buttonTamam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTamam.Location = new System.Drawing.Point(355, 90);
            this.buttonTamam.Name = "buttonTamam";
            this.buttonTamam.Size = new System.Drawing.Size(75, 23);
            this.buttonTamam.TabIndex = 5;
            this.buttonTamam.Text = "Tamam";
            this.buttonTamam.UseVisualStyleBackColor = true;
            this.buttonTamam.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.BackColor = System.Drawing.SystemColors.Window;
            this.buttonIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIptal.Location = new System.Drawing.Point(274, 90);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 6;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = false;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMesaj.ForeColor = System.Drawing.Color.Maroon;
            this.labelMesaj.Location = new System.Drawing.Point(260, 138);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(0, 15);
            this.labelMesaj.TabIndex = 7;
            // 
            // KullaniciGiris
            // 
            this.AcceptButton = this.buttonTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonIptal;
            this.ClientSize = new System.Drawing.Size(454, 166);
            this.Controls.Add(this.labelMesaj);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonTamam);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "KullaniciGiris";
            this.Text = "KullaniciGiris";
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonTamam;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Label labelMesaj;
    }
}