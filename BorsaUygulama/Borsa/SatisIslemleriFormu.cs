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
    public partial class SatisIslemleriFormu : Form
    {
        SatisIslemleriManager satisIslemleri = new SatisIslemleriManager();
        public SatisIslemleriFormu()
        {
            InitializeComponent();
        }

        private void btnSatisIstegiGonder_Click(object sender, EventArgs e)
        {
            if (!BosGecildiMi()) //Alanlar bos gecilmediyse satis istegi gonderilir.
            {
                satisIslemleri.SatisIstegiGonder(cmbSatilacakUrun.Text, Convert.ToInt32(txtSatisMiktari.Text), Convert.ToInt32(txtSatisFiyati.Text));
            }
        }
        public Boolean BosGecildiMi()
        {
            //Alanlari bos gecilip gecilmedigi kontrol edilir.
            if (txtSatisFiyati.Text == "" || txtSatisMiktari.Text == "" || cmbSatilacakUrun.SelectedItem == null)
            {
                MessageBox.Show("Hiçbir Alan Boş Geçilemez!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtSatisMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayi ve kontrol tuslari
        }
        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayi ve kontrol tuslari
        }
    }
}
