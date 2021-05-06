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
        private KullaniciManager kullaniciManager = new KullaniciManager();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (!BosGecildiMi()) //Hicbir alan bos gecilmediyse kullaniciyi ekler.
            {
                KullaniciTbl kullanici = new KullaniciTbl
                {
                    KullaniciAd = txtAd.Text,
                    KullaniciAdi = txtKullaniciAd.Text,
                    KullaniciSoyad = txtSoyad.Text,
                    KullaniciAdres = txtAdres.Text,
                    KullaniciTc = txtTC.Text,
                    KullaniciTelefon = txtTel.Text,
                    KullaniciSifre = txtSifre.Text,
                    KullaniciMail = txtMail.Text
                }; //kullaniciTbl sinifindan nesne olusturulur ve olusan nesne kullaniciManager sinifinin kullanici ekle metotuna parametre olarak gönderilir
                Kontrol(kullaniciManager.KullaniciEkle(kullanici)); //Kullanicinin veritabanina eklenip eklenmedigi bilgisi getirilir.
            }
        }
        private void Kontrol(Boolean eklendiMi) //Veritabanina kullanici eklendiyse textlerin icini bosaltir.
        {
            if (eklendiMi)
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
        private Boolean BosGecildiMi() //Alanlarin bos gecilip gecilmedigi bilgisini dondurur.
        {
            if (txtAd.Text == "" || txtKullaniciAd.Text == "" || txtSoyad.Text == "" || txtAdres.Text == "" ||
            txtTC.Text == "" || txtTel.Text == "" || txtSifre.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Hic bir alan boş gecilemez");
                return true; 
            }
            else
            {
                return false; //bos gelcilmediyse ekleme islemi icin izin ver
            }
        }
        //textlere veri girislerini sinirlaryan kısımlar 
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);//boşluk ve harf
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayisal degerlere ve kontrol islemlerine izin verir(delete tusu)
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);//boşluk ve harf
        }
    }
}
