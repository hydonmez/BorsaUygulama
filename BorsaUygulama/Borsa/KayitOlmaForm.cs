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
    public partial class KayitOlmaForm : Form
    {
        public KayitOlmaForm()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KullaniciTbl kullanici = new KullaniciTbl();
            kullanici.KullaniciAd = txtAd.Text;
            kullanici.KullaniciAdi = txtKullaniciAd.Text;
            kullanici.KullaniciSoyad = txtSoyad.Text;
            kullanici.KullaniciAdres = txtAdres.Text;
            kullanici.KullaniciTc = txtTC.Text;
            kullanici.KullaniciTelefon = txtTel.Text;
            kullanici.KullaniciSifre = txtSifre.Text;
            kullanici.KullaniciMail = txtMail.Text;
            Kontrol(kullanicimanager.KullaniciEkle(kullanici));
        }
        public void Kontrol(Boolean eklendimi)
        {
            if (eklendimi == true)
            {
                txtAd.Text = "";
                txtKullaniciAd.Text = "";
                txtSoyad.Text = "";
                txtAdres.Text = "";
                txtTC.Text = "";
                txtTel.Text = "";
                txtSifre.Text = "";
                txtMail.Text = "";

            }
        }
    }
}
