
namespace Borsa
{
    partial class SatisIslemleriFormu
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
            this.btnSatisIstegiGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisMiktari = new System.Windows.Forms.TextBox();
            this.cmbSatilacakUrun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSatisIstegiGonder
            // 
            this.btnSatisIstegiGonder.Location = new System.Drawing.Point(131, 133);
            this.btnSatisIstegiGonder.Name = "btnSatisIstegiGonder";
            this.btnSatisIstegiGonder.Size = new System.Drawing.Size(121, 26);
            this.btnSatisIstegiGonder.TabIndex = 20;
            this.btnSatisIstegiGonder.Text = "Satis isteği gönder";
            this.btnSatisIstegiGonder.UseVisualStyleBackColor = true;
            this.btnSatisIstegiGonder.Click += new System.EventHandler(this.btnSatisIstegiGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Satis Fiyati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Satilacak Miktar";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(131, 96);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(121, 20);
            this.txtSatisFiyati.TabIndex = 17;
            this.txtSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisFiyati_KeyPress);
            // 
            // txtSatisMiktari
            // 
            this.txtSatisMiktari.Location = new System.Drawing.Point(131, 57);
            this.txtSatisMiktari.Name = "txtSatisMiktari";
            this.txtSatisMiktari.Size = new System.Drawing.Size(121, 20);
            this.txtSatisMiktari.TabIndex = 16;
            this.txtSatisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisMiktari_KeyPress);
            // 
            // cmbSatilacakUrun
            // 
            this.cmbSatilacakUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatilacakUrun.FormattingEnabled = true;
            this.cmbSatilacakUrun.Items.AddRange(new object[] {
            "Bugday",
            "Petrol",
            "Yulaf"});
            this.cmbSatilacakUrun.Location = new System.Drawing.Point(131, 19);
            this.cmbSatilacakUrun.Name = "cmbSatilacakUrun";
            this.cmbSatilacakUrun.Size = new System.Drawing.Size(121, 21);
            this.cmbSatilacakUrun.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Satmak İstenilen Ürün";
            // 
            // SatisIslemleriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 189);
            this.Controls.Add(this.btnSatisIstegiGonder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtSatisMiktari);
            this.Controls.Add(this.cmbSatilacakUrun);
            this.Controls.Add(this.label1);
            this.Name = "SatisIslemleriFormu";
            this.Text = "SatisIslemleriFormu";
            this.Load += new System.EventHandler(this.SatisIslemleriFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatisIstegiGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtSatisMiktari;
        private System.Windows.Forms.ComboBox cmbSatilacakUrun;
        private System.Windows.Forms.Label label1;
    }
}