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
    public partial class KullaniciIslemleriMenuForm : Form
    {
        public KullaniciIslemleriMenuForm()
        {
            InitializeComponent();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            SatisIslemleriFormu satisislemi = new SatisIslemleriFormu();
            satisislemi.Show();
        }

        private void btnAlis_Click(object sender, EventArgs e)
        {
            AlisIslemleriForm alisIslemleri = new AlisIslemleriForm();
            alisIslemleri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BilgiGirisEkrani bilgigiris = new BilgiGirisEkrani();
            bilgigiris.Show();
        }
    }
}
