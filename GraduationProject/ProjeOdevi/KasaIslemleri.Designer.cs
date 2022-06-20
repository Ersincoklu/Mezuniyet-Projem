namespace ProjeOdevi
{
    partial class KasaIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kasa Ad :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(68, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(68, 75);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(176, 20);
            this.txtAd.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(168, 136);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(13, 175);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(87, 136);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // KasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 200);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KasaIslemleri";
            this.Text = "KasaIslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnGuncelle;
    }
}