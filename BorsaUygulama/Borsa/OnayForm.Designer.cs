
namespace Borsa
{
    partial class OnayForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnayForm));
            this.btnReddet = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.grdOnayTablosu = new System.Windows.Forms.DataGridView();
            this.lblOnay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formuKapat = new System.Windows.Forms.Label();
            this.formuKucult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOnayTablosu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnReddet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReddet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReddet.ForeColor = System.Drawing.Color.White;
            this.btnReddet.Location = new System.Drawing.Point(144, 198);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(119, 41);
            this.btnReddet.TabIndex = 8;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnayla.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(9, 198);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(121, 41);
            this.btnOnayla.TabIndex = 7;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // grdOnayTablosu
            // 
            this.grdOnayTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdOnayTablosu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdOnayTablosu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.grdOnayTablosu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOnayTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOnayTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOnayTablosu.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdOnayTablosu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.grdOnayTablosu.Location = new System.Drawing.Point(9, 34);
            this.grdOnayTablosu.MultiSelect = false;
            this.grdOnayTablosu.Name = "grdOnayTablosu";
            this.grdOnayTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOnayTablosu.Size = new System.Drawing.Size(758, 159);
            this.grdOnayTablosu.TabIndex = 6;
            // 
            // lblOnay
            // 
            this.lblOnay.AutoSize = true;
            this.lblOnay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.lblOnay.Location = new System.Drawing.Point(6, 7);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(243, 23);
            this.lblOnay.TabIndex = 9;
            this.lblOnay.Text = "Onay Bekleyen İşlemler:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnReddet);
            this.panel1.Controls.Add(this.lblOnay);
            this.panel1.Controls.Add(this.btnOnayla);
            this.panel1.Controls.Add(this.grdOnayTablosu);
            this.panel1.Location = new System.Drawing.Point(-2, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 266);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(148)))), ((int)(((byte)(6)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.formuKapat);
            this.panel3.Controls.Add(this.formuKucult);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(-2, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 50);
            this.panel3.TabIndex = 18;
            // 
            // formuKapat
            // 
            this.formuKapat.AutoSize = true;
            this.formuKapat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formuKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.formuKapat.Location = new System.Drawing.Point(732, 20);
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
            this.formuKucult.Location = new System.Drawing.Point(705, 20);
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
            this.label7.Location = new System.Drawing.Point(14, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Onay İşlemleri";
            // 
            // OnayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 301);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OnayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onay Formu";
            this.Load += new System.EventHandler(this.OnayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOnayTablosu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.DataGridView grdOnayTablosu;
        private System.Windows.Forms.Label lblOnay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label formuKapat;
        private System.Windows.Forms.Label formuKucult;
        private System.Windows.Forms.Label label7;
    }
}