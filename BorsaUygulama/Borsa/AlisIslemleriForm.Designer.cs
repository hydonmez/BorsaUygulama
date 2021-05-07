
namespace Borsa
{
    partial class AlisIslemleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlisIslemleriForm));
            this.btnAlisIstegi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlisMiktari = new System.Windows.Forms.TextBox();
            this.cmbAlınacakUrun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formuKapat = new System.Windows.Forms.Label();
            this.formuKucult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlisIstegi
            // 
            this.btnAlisIstegi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btnAlisIstegi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlisIstegi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlisIstegi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAlisIstegi.Location = new System.Drawing.Point(197, 82);
            this.btnAlisIstegi.Name = "btnAlisIstegi";
            this.btnAlisIstegi.Size = new System.Drawing.Size(158, 46);
            this.btnAlisIstegi.TabIndex = 23;
            this.btnAlisIstegi.Text = "Alış İsteği Gönder";
            this.btnAlisIstegi.UseVisualStyleBackColor = false;
            this.btnAlisIstegi.Click += new System.EventHandler(this.btnAlisIstegi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Alınacak Miktar(Kg):";
            // 
            // txtAlisMiktari
            // 
            this.txtAlisMiktari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.txtAlisMiktari.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisMiktari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtAlisMiktari.Location = new System.Drawing.Point(197, 49);
            this.txtAlisMiktari.Name = "txtAlisMiktari";
            this.txtAlisMiktari.Size = new System.Drawing.Size(158, 27);
            this.txtAlisMiktari.TabIndex = 21;
            this.txtAlisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlisMiktari_KeyPress);
            // 
            // cmbAlınacakUrun
            // 
            this.cmbAlınacakUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.cmbAlınacakUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlınacakUrun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAlınacakUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cmbAlınacakUrun.FormattingEnabled = true;
            this.cmbAlınacakUrun.Items.AddRange(new object[] {
            "Bugday",
            "Petrol",
            "Yulaf"});
            this.cmbAlınacakUrun.Location = new System.Drawing.Point(197, 16);
            this.cmbAlınacakUrun.Name = "cmbAlınacakUrun";
            this.cmbAlınacakUrun.Size = new System.Drawing.Size(158, 27);
            this.cmbAlınacakUrun.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Almak İstenilen Ürün:";
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
            this.panel3.Size = new System.Drawing.Size(393, 41);
            this.panel3.TabIndex = 24;
            // 
            // formuKapat
            // 
            this.formuKapat.AutoSize = true;
            this.formuKapat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formuKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.formuKapat.Location = new System.Drawing.Point(353, 9);
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
            this.formuKucult.Location = new System.Drawing.Point(326, 9);
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
            this.label7.Location = new System.Drawing.Point(2, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Alış İşlemleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbAlınacakUrun);
            this.panel1.Controls.Add(this.btnAlisIstegi);
            this.panel1.Controls.Add(this.txtAlisMiktari);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 157);
            this.panel1.TabIndex = 25;
            // 
            // AlisIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 196);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlisIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alis İslemleri";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlisIstegi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlisMiktari;
        private System.Windows.Forms.ComboBox cmbAlınacakUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label formuKapat;
        private System.Windows.Forms.Label formuKucult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}