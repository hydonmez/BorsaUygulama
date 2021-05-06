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
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
       private KullaniciGirisIslemleriManager girisIslemleri = new KullaniciGirisIslemleriManager();
        private AdminGirisIslemleriManager adminIslemleri = new AdminGirisIslemleriManager();
       private KullaniciTbl kullanici = new KullaniciTbl();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOlmaForm kayitOl = new KayitOlmaForm();
            kayitOl.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            kullanici.KullaniciSifre = txtSifre.Text;
            girisIslemleri.GirisYap(kullanici);
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {

            AdminTbl admin = new AdminTbl();
            admin.AdmiKullaniciAdi = txtAdminKullaniciAdi.Text;
            admin.AdminSifre = txtAdminSifre.Text;
            adminIslemleri.GirisYap(admin);

        
        }
    }
}
