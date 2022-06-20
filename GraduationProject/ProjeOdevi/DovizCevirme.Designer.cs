namespace ProjeOdevi
{
    partial class DovizCevirme
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.btnTL = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EURO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOLAR :";
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(70, 15);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(155, 20);
            this.txtTL.TabIndex = 3;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(70, 42);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(155, 20);
            this.txtEuro.TabIndex = 4;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(70, 70);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(155, 20);
            this.txtDolar.TabIndex = 5;
            // 
            // btnTL
            // 
            this.btnTL.Location = new System.Drawing.Point(231, 13);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(75, 23);
            this.btnTL.TabIndex = 6;
            this.btnTL.Text = "ÇEVİR";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(231, 40);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(75, 23);
            this.btnEuro.TabIndex = 6;
            this.btnEuro.Text = "ÇEVİR";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(231, 68);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 6;
            this.btnDolar.Text = "ÇEVİR";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // DovizCevirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 109);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnTL);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtTL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DovizCevirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DovizCevirme";
            this.Load += new System.EventHandler(this.DovizCevirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnDolar;
    }
}