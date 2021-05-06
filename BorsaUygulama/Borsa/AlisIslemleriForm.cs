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
            if (!BosMu())
            {
                AlisIslemleriManager alisIslemleri = new AlisIslemleriManager();
                alisIslemleri.AlisIstegiGonder(cmbAlınacakUrun.Text, Convert.ToInt32(txtAlisMiktari.Text));
            }           
        }
        public Boolean BosMu()
        {
            if (txtAlisMiktari.Text == "" || cmbAlınacakUrun.SelectedItem == null)
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
    }
}
