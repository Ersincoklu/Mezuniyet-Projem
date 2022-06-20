namespace ProjeOdevi
{
    partial class KaraListeIslemleri
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
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.txtSebeb = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musteri Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sebeb / Gerekçe :";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(118, 19);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(308, 20);
            this.txtMusteri.TabIndex = 2;
            // 
            // txtSebeb
            // 
            this.txtSebeb.Location = new System.Drawing.Point(118, 54);
            this.txtSebeb.Name = "txtSebeb";
            this.txtSebeb.Size = new System.Drawing.Size(308, 96);
            this.txtSebeb.TabIndex = 3;
            this.txtSebeb.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(115, 188);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 5;
            // 
            // KaraListeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 212);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSebeb);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KaraListeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KaraListeIslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.RichTextBox txtSebeb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMesaj;
    }
}