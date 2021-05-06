
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
            this.btnReddet = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.grdOnayTablosu = new System.Windows.Forms.DataGridView();
            this.lblOnay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOnayTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(207, 256);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(119, 41);
            this.btnReddet.TabIndex = 8;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(67, 256);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(121, 41);
            this.btnOnayla.TabIndex = 7;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // grdOnayTablosu
            // 
            this.grdOnayTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdOnayTablosu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdOnayTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOnayTablosu.Location = new System.Drawing.Point(48, 57);
            this.grdOnayTablosu.MultiSelect = false;
            this.grdOnayTablosu.Name = "grdOnayTablosu";
            this.grdOnayTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOnayTablosu.Size = new System.Drawing.Size(598, 159);
            this.grdOnayTablosu.TabIndex = 6;
            // 
            // lblOnay
            // 
            this.lblOnay.AutoSize = true;
            this.lblOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnay.Location = new System.Drawing.Point(45, 26);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(157, 15);
            this.lblOnay.TabIndex = 9;
            this.lblOnay.Text = "Onay Bekleyen İşlemler";
            // 
            // OnayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 318);
            this.Controls.Add(this.lblOnay);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.grdOnayTablosu);
            this.Name = "OnayForm";
            this.Text = "OnayForm";
            this.Load += new System.EventHandler(this.OnayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOnayTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.DataGridView grdOnayTablosu;
        private System.Windows.Forms.Label lblOnay;
    }
}