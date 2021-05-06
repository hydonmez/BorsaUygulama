using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
    public class KullaniciManager
    {
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        public Boolean KullaniciEkle(KullaniciTbl kullanici) //Kullanici ekleme islemi icin Kullanici nesnesi alinir.
        {
            if (!KullaniciAdKontrol(kullanici)) // Kullanici adi daha önce yoksa ekleme islemleri gerceklestirilir.
            {
                veriTabani.KullaniciTbl.Add(kullanici);//Parametre olarak gelen kullanici nesnesi KullaniciTbl'ye eklenir.
                veriTabani.SaveChanges();
                MessageBox.Show("Kullanıcı Eklendi");
                return true;
            }
            else
            {
                //Ayni kullanici adi ile KullaniciTbl'de kayit varsa hata mesaji gosterilir.
                MessageBox.Show("Bu Kullanıcı Adında Bir Kullanıcı Mevcut Yeni Bir Kullanıcı Adı Giriniz!");
                return false;
            }
        }
        public Boolean KullaniciAdKontrol(KullaniciTbl kullanici)  //Ayni kullanici adina sahip bir kullanicinin olup olmadigi kontrol edilir 
        {
            //Kullanici tablosundan parametre olarak gelen kullanici adi ile ayni kayit varsa kullanicilar listesine eklenir.
            var kullanicilar = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciAdi == kullanici.KullaniciAdi select gecici;

            if (kullanicilar.Count() == 0) //Sorgudan dönen listenin eleman sayisi yoksa alinmak istenen kullanici adi yoktur ve olmadigini boolen olarak geri dondurur.
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
