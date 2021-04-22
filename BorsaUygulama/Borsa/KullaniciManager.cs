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


        public Boolean KullaniciEkle(KullaniciTbl kullanici)
        {

            if (KullaniciAdKontrol(kullanici) == true)
            {
                veriTabani.KullaniciTbl.Add(kullanici);
                veriTabani.SaveChanges();
                
                return true;
            }
            return false;
        }
        public Boolean KullaniciAdKontrol(KullaniciTbl kullanici)
        {
            
            var sonuc = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciAdi == kullanici.KullaniciAdi select gecici;
           
            if(sonuc.Count()==0)
            {
                MessageBox.Show("kullanici eklendi");
                return true;
            }
            else
            {  
                MessageBox.Show("Bu kullanici adinda bir kullanici mevcut yeni bir kullanici adi giriniz");
                return false;
            }
        }
    }
}
