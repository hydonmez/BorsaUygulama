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
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        KullaniciTbl kullanici = new KullaniciTbl();
        public void Onaylama(OnayTbl onaylanacak)
        {
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == onaylanacak.KullaniciID select gecici;

            foreach (var item in sorgu)
            {
                item.HesaptakiPara = item.HesaptakiPara + onaylanacak.Miktar;
            }
            veriTabani.SaveChanges();
            MessageBox.Show("Secilen İslem Onaylanmıştir");

        }
        
        public void onaylama(OnayTbl onaylanacak)
        {
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == onaylanacak.KullaniciID select gecici;

            foreach (var item in sorgu)
            {

                string deger = "Hesaptaki" + onaylanacak.OnaylanacakNesne;

               
                var x =Convert.ToDecimal(item.GetType().GetProperty(deger).GetValue(item, null));
                x = x + onaylanacak.Miktar;

                item.GetType().GetProperty(deger).SetValue(item, x); 
                MessageBox.Show("Onaylanma islemi gerceklesmistir");

            }
            veriTabani.SaveChanges();


        }
    }
    }
