using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
    public partial class AlisIslemleriForm : Form
    {
        public AlisIslemleriForm()
        {
            InitializeComponent();
        }

        private void btnAlisIstegi_Click(object sender, EventArgs e)
        {
            if (!BosMu())//hicnir alan bos degilse alisistegi sisteme kayit edilir
            {
                AlisIslemleriManager alisIslemleri = new AlisIslemleriManager();
                alisIslemleri.AlisIstegiGonder(cmbAlınacakUrun.Text, Convert.ToInt32(txtAlisMiktari.Text), Convert.ToDecimal(txtAlisFiyati.Text));
            }
        }
        private Boolean BosMu()//hergangi bir alanin bos olup olmadigini kontrol ediyoruz
        {
            if (txtAlisMiktari.Text == "" || cmbAlınacakUrun.SelectedItem == null || txtAlisFiyati.Text == "")
            {
                MessageBox.Show("Hiçbir Alan Boş Geçilemez!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtAlisMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayi ve kontrol
        }

        private void formuKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void formuKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
