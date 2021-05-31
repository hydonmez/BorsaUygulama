using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
    class OnayIslemleriManager
    {
        private VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        public void Onaylama(OnayTbl onaylanacak) //Parametre olarak onaylanacak nesne alinir
        {
            //Onay tablosundaki kullaniciId ye gore ilgili kullanici verisi getirilir.
            var sorgu = from kullanici in veriTabani.KullaniciTbl where kullanici.KullaniciId == onaylanacak.KullaniciID select kullanici;

            foreach (var kullanici in sorgu)
            {

                if (onaylanacak.OnaylanacakNesne == "Euro" || onaylanacak.OnaylanacakNesne == "Dolar" || onaylanacak.OnaylanacakNesne == "Pound")
                {
                    //onaylanacak nesne icin kur bilgisi getirmek icin ilgili sınıftan bir nesne yaratıldı
                    KurHesapla kurIslemleri = new KurHesapla();
                    kullanici.HesaptakiTL += (kurIslemleri.KurBilgisiGetir(onaylanacak.OnaylanacakNesne) * onaylanacak.Miktar);//sorgudan dönen kur bilgisiyle miktar çarpılarak tl olarak kullanicinin hesabina yatırıldı.
                    MessageBox.Show("Onaylanma İşlemi Gerçekleştirildi");
                }
                else
                {
                    //Gelen onaylanacak nesnenin ön adina "Hesaptaki" kelimesini ekliyoruz
                    string deger = "Hesaptaki" + onaylanacak.OnaylanacakNesne; 

                    //Kullanici tablosundan onaylanmak istenen nesnenin mevcut miktari getirilir ve Decimal tipine cevrilir.
                    var mevcutMiktar = Convert.ToDecimal(kullanici.GetType().GetProperty(deger).GetValue(kullanici, null));

                    mevcutMiktar = mevcutMiktar + onaylanacak.Miktar; //Mevcut miktara onaylanacak miktar eklenir.
                    
                    //Kullanici tablosundan onaylanmak istenen nesnenin mevcut miktari yeni olusan mevcut miktar ile degistirilir. 
                    kullanici.GetType().GetProperty(deger).SetValue(kullanici, mevcutMiktar); 
                    MessageBox.Show("Onaylanma İşlemi Gerçekleştirildi");
                }
            }
            veriTabani.SaveChanges();//Degisiklikler veritabanina kaydedilir.
        }
    }
}
