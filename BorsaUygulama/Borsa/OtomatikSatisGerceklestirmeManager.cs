using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Borsa
{
    public class OtomatikSatisGerceklestirmeManager
    {
        private VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        private List<AliciIstekTbl> AliciIstekleriniBul(string satilanUrun) //Satilmak istenen urunu parametre olarak alir
        {
            //Alici Istek tablosundan alici isteklerini, istek tarihine göre getirir Istek tarihi aynı ise istek numarasina gore siralanir.
            var alicilar = from gecici in veriTabani.AliciIstekTbl where gecici.IstenilenUrun == satilanUrun orderby gecici.IstekTarihi, gecici.AliciIstekId select gecici;
            return alicilar.ToList();
        }
        private List<SatistakiUrunTbl> SaticiIstekleriniBul(string alinacakUrun) //Alinmak istene urunu parametre olarak alınır
        {
            /*alinmak istenen urunle ilgili saticilarin satistakiUrun tablosundan satistaki urunler fiyata göre getirilir fiyatlar esitse 
            satis tarihine göre asc formatında sıralanir ve listeye eklenir */

            var saticilar = from gecici in veriTabani.SatistakiUrunTbl
                            where gecici.SatistakiNesne == alinacakUrun
                            orderby gecici.SatistakiFiyati, gecici.SatisIstekTarihi
                            select gecici;
            return saticilar.ToList();
        }
        public void IslemleriGerceklestir(string islemYapilacakUrun) //Parametre olarak uygun olan alici isteklerini ve satici isteklerini alır
        {
            foreach (var alisIstekleri in AliciIstekleriniBul(islemYapilacakUrun))//her bir alicinin istegi gerceklestirilir.
            {
                decimal alicininParasi = AlicininParasiniGetir(alisIstekleri.KullaniciId);//alicinin parasi kullaniciId göre getirilir

                foreach (var saticiIstekleri in SaticiIstekleriniBul(alisIstekleri.IstenilenUrun))//listedeki ilk saticidan alicinin istegi gercekleştirilmek üzere bir döngüye girilir
                                                                                                  //eger ilk saticida urun bittiyse ve kullanicinin almak istedigi urun miktarina ulasilmadiysa
                {
                    int alicininAldigiUrun = 0;
                    decimal saticininKazandigiPara = 0;
                    while (saticiIstekleri.SatistakiMiktari != 0 && alisIstekleri.IstekMiktari != 0 && Convert.ToDecimal(alicininParasi) >= Convert.ToDecimal(saticiIstekleri.SatistakiFiyati))
                    {
                        /* saticinin satistablosundaki ilgili urunun miktari 0 olana denk veya 
                         alicinin ilgili urunden istek miktari 0 olana kadar veya alicin hesabındaki para saticin bir birim ürün fiyatından az oluncaya kadar döngü döner*/
                        //her döngüye girildiginde sartlar saglandigi icin;
                        alicininAldigiUrun++; //alicinin aldigi urun 1 adet artırılır 
                        saticininKazandigiPara += saticiIstekleri.SatistakiFiyati;//saticinin kazandigipara bir birim fiyati kadar artırlır
                        saticiIstekleri.SatistakiMiktari -= 1; //saticinin sattigi urun 1 adet azaltılır
                        alisIstekleri.IstekMiktari -= 1;//alicinin almak istedigi urun miktari bir adet azaltılır 
                        alicininParasi -= Convert.ToDecimal(saticiIstekleri.SatistakiFiyati);//alicinin parası bir birim urun fiyati kadar azaltılır
                    }
                    //Dongunun neden kirildigi tespit edilerek gerekli islemler yapilir.
                    if (saticiIstekleri.SatistakiMiktari == 0) //Saticinin satis istegindeki tüm ürünleri satıldıysa ilgili satis istegi tablodan silinir
                    {
                        var sorgu = veriTabani.SatistakiUrunTbl.Find(saticiIstekleri.SatisId);//İlgili satis istegi bulunur
                        if (sorgu != null)//Satis istegi null degilse istek silinir
                        {
                            veriTabani.SatistakiUrunTbl.Remove(sorgu);//SatistakiUrunTbl'de bulunan ilgili satis istegi remove metotu silinir.
                        }

                    }
                    if (alisIstekleri.IstekMiktari == 0)//alicinin alici istegindeki tüm urunler alinmissa ilgili alici istegi tablodan silinir
                    {
                        var sorgu = veriTabani.AliciIstekTbl.Find(alisIstekleri.AliciIstekId); //istek sıfırlandıysa tabloyu sil 
                        if (sorgu != null)//alic istegi null degilse alis istegi silinir 
                        {
                            veriTabani.AliciIstekTbl.Remove(sorgu);//AliciIstekTbl'de bulunan ilgili alis istegi Remove metoduyla  silinir.
                        }
                    }

                    foreach (var saticiHesabi in HesabiGetir(saticiIstekleri.KullaniciId))//saticinin hesabı getirilir ve hesabinda gerekli alis veris islmeleri gerceklestirilir
                    {
                        string deger = "Hesaptaki" + islemYapilacakUrun;
                        var x = Convert.ToDecimal(saticiHesabi.GetType().GetProperty(deger).GetValue(saticiHesabi, null));//Saticinin hesabindan sattigi urunun bilgisi getirilir
                        x -= alicininAldigiUrun; //hesaptaki mevcut urunden alicinin aldigi urun cikarilir 
                        saticiHesabi.GetType().GetProperty(deger).SetValue(saticiHesabi, x);//saticinin ilgili urunler ilgili yeni stogu kullanici hesabında güncellenir
                        saticiHesabi.HesaptakiPara += saticininKazandigiPara;//satistan kazandigi para hesabına eklenir
                    }

                    foreach (var item2 in HesabiGetir(alisIstekleri.KullaniciId))//alicinin hesabı getirilir ve hesabinda gerekli alis veris islmeleri gerceklestirilir
                    {
                        item2.HesaptakiPara -= saticininKazandigiPara; //aliciya verdiği para hesabından çikarilir ve mevcut bakiyesi güncellenir
                        string deger = "Hesaptaki" + islemYapilacakUrun;
                        var x = Convert.ToDecimal(item2.GetType().GetProperty(deger).GetValue(item2, null));//alinan urunle ilgili alicinin hesabindaki urun miktari getirilir
                        x += alicininAldigiUrun;//gelen urun miktarına yeni alinan urun miktari eklenir
                        item2.GetType().GetProperty(deger).SetValue(item2, x);//kullanicinin  hesabinda ilgili urunun miktari guncellenir                                                      
                    }
                    veriTabani.SaveChanges();//Degisiklikler kaydedilir.

                }
            }
        }
        private List<KullaniciTbl> HesabiGetir(int kullaniciId)//Parametre olarak gelen kullaniciId'ye göre hesap bilgileri dondurulur.
        {
            var hesapBilgisi = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == kullaniciId select gecici;
            return hesapBilgisi.ToList();
        }
        private decimal AlicininParasiniGetir(int kullaniciID)//parametre olarak kullanici id alır
        {
            //Kullanici tablosundaki kullanici id parametre olarak gelen kullanici id'sine esit olan kullaniciyi listeye ekler
            var kullanici = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == kullaniciID select gecici;
            foreach (var item in kullanici)
            {
                return Convert.ToDecimal(item.HesaptakiPara);//kullanicinin parasini geri doner
            }
            return 0;
        }
    }
}
