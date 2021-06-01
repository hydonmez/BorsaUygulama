
namespace Borsa
{
    partial class RaporFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporFormu));
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formuKapat = new System.Windows.Forms.Label();
            this.formuKucult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(166, 46);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(253, 27);
            this.dtpBitisTarihi.TabIndex = 83;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.CustomFormat = "yyyy-MM-dd";
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(166, 13);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(253, 27);
            this.dtpBaslangicTarihi.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Bitis Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Baslangic Tarihi:";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btnRaporAl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaporAl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnRaporAl.Location = new System.Drawing.Point(166, 79);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(249, 35);
            this.btnRaporAl.TabIndex = 11;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.dtpBitisTarihi);
            this.panel1.Controls.Add(this.dtpBaslangicTarihi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRaporAl);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 138);
            this.panel1.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.formuKapat);
            this.panel3.Controls.Add(this.formuKucult);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 45);
            this.panel3.TabIndex = 78;
            // 
            // formuKapat
            // 
            this.formuKapat.AutoSize = true;
            this.formuKapat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formuKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.formuKapat.Location = new System.Drawing.Point(427, 10);
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
            this.formuKucult.Location = new System.Drawing.Point(396, 8);
            this.formuKucult.Name = "formuKucult";
            this.formuKucult.Size = new System.Drawing.Size(21, 25);
            this.formuKucult.TabIndex = 1;
            this.formuKucult.Text = "-";
            this.formuKucult.Click += new System.EventHandler(this.formuKucult_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Rapor Alma Formu";
            // 
            // RaporFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 178);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaporFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor Formu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label formuKapat;
        private System.Windows.Forms.Label formuKucult;
        private System.Windows.Forms.Label label10;
    }
}