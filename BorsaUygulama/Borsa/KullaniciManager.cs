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
        public Boolean KullaniciEkle(KullaniciTbl kullanici) //kullanici ekleme işlemleri
        {

            if (KullaniciAdKontrol(kullanici) == false) // kullanici adi daha önce yoksa ekleme işlemleri gerçekleştiriliyor
            {
                veriTabani.KullaniciTbl.Add(kullanici);
                veriTabani.SaveChanges();
                MessageBox.Show("kullanici eklendi");
                return true; 
            }
            else
            {
                MessageBox.Show("Bu kullanici adinda bir kullanici mevcut yeni bir kullanici adi giriniz");
                return false;
            }

           
        }
        public Boolean KullaniciAdKontrol(KullaniciTbl kullanici)  //ayni kullanici adina sahip bir kullanicinin olup olmadigi kontrol ediliyor 
        {
            
            var sonuc = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciAdi == kullanici.KullaniciAdi select gecici;
           
            if(sonuc.Count()==0) //sorgudan dönen listenin eleman sayisi yoksa alınmak istenen kullanici adi yoktur ve olmadigini boolen olarak geri dönderir
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
