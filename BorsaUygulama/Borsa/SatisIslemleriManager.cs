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
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();

        public void SatisIstegiGonder(string satilacakUrun, int miktar, int fiyati)
        {

            if (SatisDogrulama(satilacakUrun,miktar))//satis izni geldiyse satistaki urunler tablosuna mevcut istegi kayıteder.
            {
                SatistakiUrunTbl satistakiUrun = new SatistakiUrunTbl();
                satistakiUrun.KullaniciId = GirisIslemleriManager.girisId;
                satistakiUrun.SatistakiNesne = satilacakUrun;
                satistakiUrun.SatistakiFiyati = fiyati;
                satistakiUrun.SatistakiMiktari = miktar;
                satistakiUrun.SatisIstekTarihi = DateTime.Now;
                veriTabani.SatistakiUrunTbl.Add(satistakiUrun);
                veriTabani.SaveChanges();
                MessageBox.Show("satis islem isteginiz gerçekleşmiştir");
            }
            else
            {
                MessageBox.Show("Satmak istediğiniz ürün miktarına sahip değilsiniz");
            }
        }
       
        public Boolean SatisDogrulama(string satilacakUrun, int miktar)
        {   
            decimal satistakiToplamUrun = 0;
            Decimal hesaptakiUrunMiktari = 0;
            //Giris yapan kullanici icin Satis Tablosunda bulunan aynı urun için daha önceki satış taleplerinin toplam miktarını hesaplar.
            var sorgu1 = from temp in veriTabani.SatistakiUrunTbl where temp.KullaniciId == GirisIslemleriManager.girisId && 
                         temp.SatistakiNesne ==satilacakUrun select temp;
           
            foreach (var item in sorgu1)
            {
                satistakiToplamUrun += item.SatistakiMiktari;
            }
           //Giris yapan kullanicinin hesabındaki mevcut urununun miktarını hesaplar.
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == GirisIslemleriManager.girisId select gecici;
            foreach (var item in sorgu)
            {
                string deger = "Hesaptaki" + satilacakUrun;
                var x= item.GetType().GetProperty(deger).GetValue(item, null);
                hesaptakiUrunMiktari = Convert.ToDecimal(x);
            }
            /*Satistaki toplam urun miktarı ile yeni satilmak
            istenen urun miktarini toplar ve mevcut kullanicinin hesabindaki urunun miktari ile karsilastirir.*/
            if(( satistakiToplamUrun+miktar) <= hesaptakiUrunMiktari)
            {
                return true; /*Mevcut toplam satis istegi miktari ile yeni satilmak istenen urun miktari hesaptaki urun miktarindan
                kucuk ve esit ise satis icin izin verir*/
            }
            else
            {
                return false;
            }

           
        }



    }

}
