namespace ProjeOdevi
{
    partial class MusteriAyar
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
            this.rbKaraListeEkle = new System.Windows.Forms.RadioButton();
            this.rbKaraListeCikar = new System.Windows.Forms.RadioButton();
            this.btnOnay = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbKaraListeEkle
            // 
            this.rbKaraListeEkle.AutoSize = true;
            this.rbKaraListeEkle.Location = new System.Drawing.Point(13, 4);
            this.rbKaraListeEkle.Name = "rbKaraListeEkle";
            this.rbKaraListeEkle.Size = new System.Drawing.Size(107, 17);
            this.rbKaraListeEkle.TabIndex = 0;
            this.rbKaraListeEkle.TabStop = true;
            this.rbKaraListeEkle.Text = "Kara Listeye Ekle";
            this.rbKaraListeEkle.UseVisualStyleBackColor = true;
            // 
            // rbKaraListeCikar
            // 
            this.rbKaraListeCikar.AutoSize = true;
            this.rbKaraListeCikar.Location = new System.Drawing.Point(13, 36);
            this.rbKaraListeCikar.Name = "rbKaraListeCikar";
            this.rbKaraListeCikar.Size = new System.Drawing.Size(117, 17);
            this.rbKaraListeCikar.TabIndex = 1;
            this.rbKaraListeCikar.TabStop = true;
            this.rbKaraListeCikar.Text = "Kara Listeden Çıkar";
            this.rbKaraListeCikar.UseVisualStyleBackColor = true;
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(12, 136);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(80, 25);
            this.btnOnay.TabIndex = 2;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(13, 103);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 57);
            this.textBox1.TabIndex = 4;
            // 
            // MusteriAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 182);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.rbKaraListeCikar);
            this.Controls.Add(this.rbKaraListeEkle);
            this.Name = "MusteriAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriAyar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKaraListeEkle;
        private System.Windows.Forms.RadioButton rbKaraListeCikar;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox textBox1;
    }
}