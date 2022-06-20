namespace ProjeOdevi
{
    partial class UrunSatis
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbOdeme = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbKasa = new System.Windows.Forms.ComboBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.lblMsj = new System.Windows.Forms.Label();
            this.btnUrunId = new System.Windows.Forms.Button();
            this.btnMusteriId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Müşteri Id :";
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(123, 42);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(182, 20);
            this.txtMusteriId.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ödeme Tipi :";
            // 
            // cbOdeme
            // 
            this.cbOdeme.FormattingEnabled = true;
            this.cbOdeme.Location = new System.Drawing.Point(123, 71);
            this.cbOdeme.Name = "cbOdeme";
            this.cbOdeme.Size = new System.Drawing.Size(228, 21);
            this.cbOdeme.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ödeme Alınan Kasa :";
            // 
            // cbKasa
            // 
            this.cbKasa.FormattingEnabled = true;
            this.cbKasa.Location = new System.Drawing.Point(123, 97);
            this.cbKasa.Name = "cbKasa";
            this.cbKasa.Size = new System.Drawing.Size(228, 21);
            this.cbKasa.TabIndex = 7;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(276, 124);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 8;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Urun Id :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(123, 16);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(182, 20);
            this.txtUrunId.TabIndex = 10;
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Location = new System.Drawing.Point(12, 159);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(0, 13);
            this.lblMsj.TabIndex = 11;
            // 
            // btnUrunId
            // 
            this.btnUrunId.Location = new System.Drawing.Point(311, 15);
            this.btnUrunId.Name = "btnUrunId";
            this.btnUrunId.Size = new System.Drawing.Size(40, 20);
            this.btnUrunId.TabIndex = 12;
            this.btnUrunId.Text = ".....";
            this.btnUrunId.UseVisualStyleBackColor = true;
            this.btnUrunId.Click += new System.EventHandler(this.btnUrunId_Click);
            // 
            // btnMusteriId
            // 
            this.btnMusteriId.Location = new System.Drawing.Point(312, 42);
            this.btnMusteriId.Name = "btnMusteriId";
            this.btnMusteriId.Size = new System.Drawing.Size(40, 20);
            this.btnMusteriId.TabIndex = 13;
            this.btnMusteriId.Text = ".....";
            this.btnMusteriId.UseVisualStyleBackColor = true;
            this.btnMusteriId.Click += new System.EventHandler(this.btnMusteriId_Click);
            // 
            // UrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 161);
            this.Controls.Add(this.btnMusteriId);
            this.Controls.Add(this.btnUrunId);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.cbKasa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbOdeme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMusteriId);
            this.Name = "UrunSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Urun Satış";
            this.Load += new System.EventHandler(this.UrunSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOdeme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.ComboBox cbKasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsj;
        public System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Button btnUrunId;
        private System.Windows.Forms.Button btnMusteriId;
    }
}