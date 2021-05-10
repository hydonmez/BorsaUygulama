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
    public partial class BilgiGirisEkrani : Form
    {
        private VeriTabaniEntities veriTabani = new VeriTabaniEntities();

        public BilgiGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnİstek_Click(object sender, EventArgs e)
        {
            if (!BosGecildiMi())//alan bos gecilmediyse onay istegi onay tablosuna kullaniciId'e gore kayit edilir
            {
                OnayTbl onaylanacak = new OnayTbl();
                onaylanacak.KullaniciID = KullaniciGirisIslemleriManager.g_girisId;
                onaylanacak.OnaylanacakNesne = cmbİstek.Text;
                onaylanacak.Miktar = Convert.ToInt32(txtMiktar.Text);
                veriTabani.OnayTbl.Add(onaylanacak);
                veriTabani.SaveChanges();
                MessageBox.Show("onay istegi sisteme kayit edilmistir");
            }
        }

        public Boolean BosGecildiMi()//herhangi bir alan bos gecildiyse isleme izin vermez
        {
            if (txtMiktar.Text == "" || cmbİstek.SelectedItem == null)
            {
                MessageBox.Show("Hiç bir alan boş gecilemez");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
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
        private void TabloyuGoster()//kullanicinin hesapb bilgileri giris id'sine göre getirilir
        {
            var sorgu = from gecici in veriTabani.KullaniciTbl
                        where gecici.KullaniciId == KullaniciGirisIslemleriManager.g_girisId
                        select new
                        {
                            KullaniciID = gecici.KullaniciId,
                            Adınız_Soyadınız = gecici.KullaniciAd + " " + gecici.KullaniciSoyad,
                            Paranız_Tl = gecici.HesaptakiPara,
                            Buğdayınız_Kg = gecici.HesaptakiBugday,
                            Yulafınız_Kg = gecici.HesaptakiYulaf,
                            Petrolünüz_Varil = gecici.HesaptakiPetrol
                        };
            grdHesapBilgileriTablo.DataSource = sorgu.ToList();
        }

        private void BilgiGirisEkrani_Load(object sender, EventArgs e)
        {
            TabloyuGoster();//ekran acildiginda kullanicinin hesap bilgileri gösterilir
        }
    }
}
