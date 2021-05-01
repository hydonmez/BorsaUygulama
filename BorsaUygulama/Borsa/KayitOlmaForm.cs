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
        VeriTabaniEntities veritabani = new VeriTabaniEntities();
        KullaniciManager kullanicimanager = new KullaniciManager();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if(!BosGecildiMi())
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
        }
        public void Kontrol(Boolean eklendimi)
        {
            if (eklendimi)
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
        public Boolean BosGecildiMi()
        {
            if (txtAd.Text == ""|| txtKullaniciAd.Text == ""|| txtSoyad.Text == "" || txtAdres.Text == "" ||
            txtTC.Text == "" || txtTel.Text == "" || txtSifre.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Hiç bir alan boş gecilemez");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar)&&!char.IsControl(e.KeyChar);//boşluk ve harf
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)&&!char.IsControl(e.KeyChar);//boşluk ve harf
        }

        private void KayitOlmaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
