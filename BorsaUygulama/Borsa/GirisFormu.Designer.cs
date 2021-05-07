
namespace Borsa
{
    partial class GirisFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.txtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formuKapat = new System.Windows.Forms.Label();
            this.formuKucult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.txtAdminSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminSifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtAdminSifre.Location = new System.Drawing.Point(118, 36);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(131, 20);
            this.txtAdminSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre: ";
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btnAdminGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminGiris.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.ForeColor = System.Drawing.Color.White;
            this.btnAdminGiris.Location = new System.Drawing.Point(118, 62);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(131, 35);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // txtAdminKullaniciAdi
            // 
            this.txtAdminKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.txtAdminKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtAdminKullaniciAdi.Location = new System.Drawing.Point(118, 10);
            this.txtAdminKullaniciAdi.Name = "txtAdminKullaniciAdi";
            this.txtAdminKullaniciAdi.Size = new System.Drawing.Size(131, 20);
            this.txtAdminKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnKayitOl);
            this.panel2.Controls.Add(this.txtSifre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnGiris);
            this.panel2.Controls.Add(this.txtKullaniciAdi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(285, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 143);
            this.panel2.TabIndex = 14;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnKayitOl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitOl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(123, 100);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(131, 35);
            this.btnKayitOl.TabIndex = 5;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtSifre.Location = new System.Drawing.Point(123, 33);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(131, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre: ";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btnGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(123, 59);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(131, 35);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(123, 9);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(131, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kullanıcı Adı: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtAdminSifre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdminGiris);
            this.panel1.Controls.Add(this.txtAdminKullaniciAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 143);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label6.Location = new System.Drawing.Point(284, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kullanıcı Giriş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(14, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Admin Giriş";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.formuKapat);
            this.panel3.Controls.Add(this.formuKucult);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(-5, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 56);
            this.panel3.TabIndex = 17;
            // 
            // formuKapat
            // 
            this.formuKapat.AutoSize = true;
            this.formuKapat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formuKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.formuKapat.Location = new System.Drawing.Point(542, 11);
            this.formuKapat.Name = "formuKapat";
            this.formuKapat.Size = new System.Drawing.Size(26, 25);
            this.formuKapat.TabIndex = 2;
            this.formuKapat.Text = "X";
            this.formuKapat.Click += new System.EventHandler(this.formuKapat_Click_1);
            // 
            // formuKucult
            // 
            this.formuKucult.AutoSize = true;
            this.formuKucult.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formuKucult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.formuKucult.Location = new System.Drawing.Point(515, 11);
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
            this.label7.Location = new System.Drawing.Point(8, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giriş";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(-5, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 196);
            this.panel4.TabIndex = 18;
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 236);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris Formu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.TextBox txtAdminKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label formuKapat;
        private System.Windows.Forms.Label formuKucult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
    }
}

