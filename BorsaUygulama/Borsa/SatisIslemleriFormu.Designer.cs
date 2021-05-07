
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisIslemleriFormu));
            this.btnSatisIstegiGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisMiktari = new System.Windows.Forms.TextBox();
            this.cmbSatilacakUrun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formuKapat = new System.Windows.Forms.Label();
            this.formuKucult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSatisIstegiGonder
            // 
            this.btnSatisIstegiGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnSatisIstegiGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatisIstegiGonder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisIstegiGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnSatisIstegiGonder.Location = new System.Drawing.Point(214, 127);
            this.btnSatisIstegiGonder.Name = "btnSatisIstegiGonder";
            this.btnSatisIstegiGonder.Size = new System.Drawing.Size(140, 54);
            this.btnSatisIstegiGonder.TabIndex = 20;
            this.btnSatisIstegiGonder.Text = "Satis isteği gönder";
            this.btnSatisIstegiGonder.UseVisualStyleBackColor = false;
            this.btnSatisIstegiGonder.Click += new System.EventHandler(this.btnSatisIstegiGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Satis Fiyati (₺):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Satilacak Miktar(Kg):";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.txtSatisFiyati.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtSatisFiyati.Location = new System.Drawing.Point(214, 94);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(140, 27);
            this.txtSatisFiyati.TabIndex = 17;
            this.txtSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisFiyati_KeyPress);
            // 
            // txtSatisMiktari
            // 
            this.txtSatisMiktari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.txtSatisMiktari.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisMiktari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtSatisMiktari.Location = new System.Drawing.Point(214, 55);
            this.txtSatisMiktari.Name = "txtSatisMiktari";
            this.txtSatisMiktari.Size = new System.Drawing.Size(140, 27);
            this.txtSatisMiktari.TabIndex = 16;
            this.txtSatisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisMiktari_KeyPress);
            // 
            // cmbSatilacakUrun
            // 
            this.cmbSatilacakUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.cmbSatilacakUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatilacakUrun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSatilacakUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.cmbSatilacakUrun.FormattingEnabled = true;
            this.cmbSatilacakUrun.Items.AddRange(new object[] {
            "Bugday",
            "Petrol",
            "Yulaf"});
            this.cmbSatilacakUrun.Location = new System.Drawing.Point(214, 17);
            this.cmbSatilacakUrun.Name = "cmbSatilacakUrun";
            this.cmbSatilacakUrun.Size = new System.Drawing.Size(140, 27);
            this.cmbSatilacakUrun.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Satmak İstenilen Ürün";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSatisIstegiGonder);
            this.panel1.Controls.Add(this.cmbSatilacakUrun);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSatisMiktari);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSatisFiyati);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 184);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.formuKapat);
            this.panel3.Controls.Add(this.formuKucult);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 49);
            this.panel3.TabIndex = 22;
            // 
            // formuKapat
            // 
            this.formuKapat.AutoSize = true;
            this.formuKapat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formuKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.formuKapat.Location = new System.Drawing.Point(328, 9);
            this.formuKapat.Name = "formuKapat";
            this.formuKapat.Size = new System.Drawing.Size(26, 25);
            this.formuKapat.TabIndex = 2;
            this.formuKapat.Text = "X";
            this.formuKapat.Click += new System.EventHandler(this.formuKapat_Click);
            // 
            // formuKucult
            // 
            this.formuKucult.AutoSize = true;
            this.formuKucult.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formuKucult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.formuKucult.Location = new System.Drawing.Point(301, 9);
            this.formuKucult.Name = "formuKucult";
            this.formuKucult.Size = new System.Drawing.Size(21, 25);
            this.formuKucult.TabIndex = 1;
            this.formuKucult.Text = "-";
            this.formuKucult.Click += new System.EventHandler(this.formuKucult_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(12, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Satış İşlemleri";
            // 
            // SatisIslemleriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 232);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SatisIslemleriFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satis İslemleri Formu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSatisIstegiGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtSatisMiktari;
        private System.Windows.Forms.ComboBox cmbSatilacakUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label formuKapat;
        private System.Windows.Forms.Label formuKucult;
        private System.Windows.Forms.Label label7;
    }
}