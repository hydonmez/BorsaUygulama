﻿
namespace Borsa
{
    partial class BilgiGirisEkrani
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnİstek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbİstek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btnİstek
            // 
            this.btnİstek.Location = new System.Drawing.Point(122, 83);
            this.btnİstek.Name = "btnİstek";
            this.btnİstek.Size = new System.Drawing.Size(121, 23);
            this.btnİstek.TabIndex = 13;
            this.btnİstek.Text = "Onay Talebinde Bulun";
            this.btnİstek.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Miktar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Onaylanacak Nesne";
            // 
            // cmbİstek
            // 
            this.cmbİstek.FormattingEnabled = true;
            this.cmbİstek.Items.AddRange(new object[] {
            "Para",
            "Arpa",
            "Buğday"});
            this.cmbİstek.Location = new System.Drawing.Point(122, 17);
            this.cmbİstek.Name = "cmbİstek";
            this.cmbİstek.Size = new System.Drawing.Size(121, 21);
            this.cmbİstek.TabIndex = 10;
            // 
            // BilgiGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 239);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnİstek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbİstek);
            this.Name = "BilgiGirisEkrani";
            this.Text = "BilgiGirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnİstek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbİstek;
    }
}