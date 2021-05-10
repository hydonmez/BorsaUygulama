using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
    public class SatisIslemleriManager
    {
        private VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        private OtomatikSatisGerceklestirmeManager otomatikSatis = new OtomatikSatisGerceklestirmeManager();
        public void SatisIstegiGonder(string satilacakUrun, int miktar, int fiyati)//Parametre olarak satilacak ürünle ilgili bilgiler alinir
        {

            if (SatisDogrulama(satilacakUrun, miktar))//Satis izni geldiyse satistaki urunler tablosuna mevcut istegi kayit eder.
            {
                SatistakiUrunTbl satistakiUrun = new SatistakiUrunTbl //Satis tablosundan bir nesne yaratilir.
                {
                    KullaniciId = KullaniciGirisIslemleriManager.g_girisId, //Yaratilan nesnenin ilgili bilgileri formdan parametra olarak alinir
                    SatistakiNesne = satilacakUrun,
                    SatistakiFiyati = fiyati,
                    SatistakiMiktari = miktar,
                    SatisIstekTarihi = DateTime.Now
                };

                veriTabani.SatistakiUrunTbl.Add(satistakiUrun);//Satis istegini satistaki ürünler tablosuna kayıt etme islemi gerceklesiyor
                veriTabani.SaveChanges();//Degisiklikler kayit edilir 
                MessageBox.Show("Satış İsteğiniz Alınmıştır");
                otomatikSatis.IslemleriGerceklestir(satilacakUrun);//Satis istegi kayıt edildikten sonra otomatik satis islemleri için fonksiyon cagrilir
            }
            else
            {   //Eger satis dogrulama false bir deger gönderirse kullanicin daha önce satis tablosunda hesabındakinden daha cok urun sattigi icin kullanici bilgilendirilir.
                MessageBox.Show("Satmak İstediğiniz Ürün Miktarına Sahip Değilsiniz!");
            }
        }
        private Boolean SatisDogrulama(string satilacakUrun, int miktar)
        {   //Kullanicin hesabındaki ürünlerle mevcut satis istek tablosundaki satislarin karsilastirilmasi yapiliyor
            decimal satistakiToplamUrun = 0;
            decimal hesaptakiUrunMiktari = 0;
            //Giris yapan kullanici icin Satis Tablosunda bulunan aynı urun için daha önceki satis taleplerinin toplam miktarını hesaplar.
            var sorgu1 = from satistakiUrun in veriTabani.SatistakiUrunTbl
                         where satistakiUrun.KullaniciId == KullaniciGirisIslemleriManager.g_girisId &&
                         satistakiUrun.SatistakiNesne == satilacakUrun
                         select satistakiUrun;

            foreach (var satis in sorgu1)
            {
                satistakiToplamUrun += satis.SatistakiMiktari;
            }
            //Giris yapan kullanicinin hesabindaki mevcut urununun miktarını hesaplar.
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == KullaniciGirisIslemleriManager.g_girisId select gecici;
            foreach (var item in sorgu)
            {
                string deger = "Hesaptaki" + satilacakUrun;
                var x = item.GetType().GetProperty(deger).GetValue(item, null);//Satilmak istenen urunun kullanicinin hesabindaki o nesnenin miktari getirilir
                hesaptakiUrunMiktari = Convert.ToDecimal(x);
            }
            /*Satistaki toplam urun miktarı ile yeni satilmak
            istenen urun miktarini toplar ve mevcut kullanicinin hesabindaki urunun miktari ile karsilastirir.*/
            if ((satistakiToplamUrun + miktar) <= hesaptakiUrunMiktari)
            {
                return true; /*Mevcut toplam satis istegi miktari ile yeni satilmak istenen urun miktari hesaptaki urun miktarindan
                kucuk ve esit ise satis icin izin verir*/
            }
            else
            {
                return false; //Eğer kosul saglanmazsa false dondurur ve izin vermez.
            }
        }
    }
}
