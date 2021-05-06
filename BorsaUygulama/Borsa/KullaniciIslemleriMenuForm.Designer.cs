
namespace Borsa
{
    partial class KullaniciIslemleriMenuForm
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
            this.btnNesneYukleme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlis = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNesneYukleme
            // 
            this.btnNesneYukleme.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNesneYukleme.Location = new System.Drawing.Point(21, 105);
            this.btnNesneYukleme.Name = "btnNesneYukleme";
            this.btnNesneYukleme.Size = new System.Drawing.Size(186, 23);
            this.btnNesneYukleme.TabIndex = 11;
            this.btnNesneYukleme.Text = "Hesaba Para ve Ürün Yükleme";
            this.btnNesneYukleme.UseVisualStyleBackColor = true;
            this.btnNesneYukleme.Click += new System.EventHandler(this.btnNesneYukleme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "İşlem Seçiniz";
            // 
            // btnAlis
            // 
            this.btnAlis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlis.Location = new System.Drawing.Point(21, 76);
            this.btnAlis.Name = "btnAlis";
            this.btnAlis.Size = new System.Drawing.Size(186, 23);
            this.btnAlis.TabIndex = 9;
            this.btnAlis.Text = "Alış İslemleri";
            this.btnAlis.UseVisualStyleBackColor = true;
            this.btnAlis.Click += new System.EventHandler(this.btnAlis_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(21, 48);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(186, 23);
            this.btnSatis.TabIndex = 8;
            this.btnSatis.Text = "Satis İslemleri";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // KullaniciIslemleriMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 184);
            this.Controls.Add(this.btnNesneYukleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlis);
            this.Controls.Add(this.btnSatis);
            this.Name = "KullaniciIslemleriMenuForm";
            this.Text = "KullaniciIslemleriMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNesneYukleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlis;
        private System.Windows.Forms.Button btnSatis;
    }
}