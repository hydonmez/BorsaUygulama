
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
            this.btnAlisIstegi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlisMiktari = new System.Windows.Forms.TextBox();
            this.cmbAlınacakUrun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlisIstegi
            // 
            this.btnAlisIstegi.Location = new System.Drawing.Point(128, 96);
            this.btnAlisIstegi.Name = "btnAlisIstegi";
            this.btnAlisIstegi.Size = new System.Drawing.Size(121, 26);
            this.btnAlisIstegi.TabIndex = 23;
            this.btnAlisIstegi.Text = "Alış İsteği Gönder";
            this.btnAlisIstegi.UseVisualStyleBackColor = true;
            this.btnAlisIstegi.Click += new System.EventHandler(this.btnAlisIstegi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Alınacak Miktar:";
            // 
            // txtAlisMiktari
            // 
            this.txtAlisMiktari.Location = new System.Drawing.Point(128, 60);
            this.txtAlisMiktari.Name = "txtAlisMiktari";
            this.txtAlisMiktari.Size = new System.Drawing.Size(121, 20);
            this.txtAlisMiktari.TabIndex = 21;
            this.txtAlisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlisMiktari_KeyPress);
            // 
            // cmbAlınacakUrun
            // 
            this.cmbAlınacakUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlınacakUrun.FormattingEnabled = true;
            this.cmbAlınacakUrun.Items.AddRange(new object[] {
            "Bugday",
            "Petrol",
            "Yulaf"});
            this.cmbAlınacakUrun.Location = new System.Drawing.Point(128, 22);
            this.cmbAlınacakUrun.Name = "cmbAlınacakUrun";
            this.cmbAlınacakUrun.Size = new System.Drawing.Size(121, 21);
            this.cmbAlınacakUrun.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Almak İstenilen Ürün:";
            // 
            // AlisIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 163);
            this.Controls.Add(this.btnAlisIstegi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlisMiktari);
            this.Controls.Add(this.cmbAlınacakUrun);
            this.Controls.Add(this.label1);
            this.Name = "AlisIslemleriForm";
            this.Text = "AlisIslemleriForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlisIstegi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlisMiktari;
        private System.Windows.Forms.ComboBox cmbAlınacakUrun;
        private System.Windows.Forms.Label label1;
    }
}