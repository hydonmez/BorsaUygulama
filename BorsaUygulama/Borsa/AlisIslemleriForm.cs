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
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        OtomatikSatisGerceklestirmeManager otomatikSatis = new OtomatikSatisGerceklestirmeManager();
        public void AlisIstegiGonder(string alinacakUrun, int miktar, decimal fiyat) //Parametre olarak alinacak ürünle ilgili bilgiler alinir
        {
            if (ParaYeterliMi()) //Alicinin parasi yeterli ise alis istegi kabul edilir.
            {
                AliciIstekTbl alisIstek = new AliciIstekTbl
                {
                    //Formdan alinacak urunle ilgili bilgiler getirilir ve aktarilir.
                    KullaniciId = KullaniciGirisIslemleriManager.g_girisId,
                    IstenilenUrun = alinacakUrun,
                    IstekMiktari = miktar,
                    IstekTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString()),
                    IstekFiyati = fiyat
                };
                veriTabani.AliciIstekTbl.Add(alisIstek); //Veritabaninda bulunan AliciIstekTbl'a alis istegi eklenir.
                veriTabani.SaveChanges(); ////Degisiklikler kayıt edilir.
                MessageBox.Show("Alış İsteğiniz Alınmıştır");
                otomatikSatis.IslemleriGerceklestir(alinacakUrun);////Alis istegi kayıt edildikten sonra otomatik satis islemleri için fonksiyon cagrilir
            }
            else
            {
                //Hesapta para yoksa kullaniciya uyari mesaji gosterilir.
                MessageBox.Show("Hesabınızda Para Bulumamaktadır!");
            }
        }
        private Boolean ParaYeterliMi() //Kullanicinin hesabindaki paranin 0'dan buyuk oldugunu kontrol eder.
        {
            //Giris yapan kullanicinin Id'si ile kullanici tablosundaki kullanici Id'si eslesen veri listeye eklenir.
            var kullanici = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == KullaniciGirisIslemleriManager.g_girisId select gecici;
            foreach (var kullaniciBilgileri in kullanici)
            {
                if (kullaniciBilgileri.HesaptakiTL > 0) //Hesaptaki para 0'dan buyuk ise alis izni verilir.
                {
                    return true;
                }
            }
            return false; ////Hesaptaki para 0'dan buyuk degilse alis izni verilmez.
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
