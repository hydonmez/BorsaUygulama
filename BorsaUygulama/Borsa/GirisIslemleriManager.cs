using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
    public class GirisIslemleriManager
    {
       public static int girisId;


        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        public void GirisYapKullanici(KullaniciTbl kullanici)
        {
            var sonuc = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciAdi == kullanici.KullaniciAdi 
                        &&gecici.KullaniciSifre==kullanici.KullaniciSifre select gecici;
            foreach (var item in sonuc)
            {
                girisId = item.KullaniciId;
            }
            if(sonuc.Any())//sonuc listesinde bir kayıt varsa true döner ve formu açar 
            {
                
                KullaniciIslemleriMenuForm kullaniciIslemlerimenu = new KullaniciIslemleriMenuForm();             
                kullaniciIslemlerimenu.Show();
            }
            else
            {
                MessageBox.Show("Hatali giris yaptınız");
            }
        }

        public void GirisYapAdmin(AdminTbl admin)
        {
            var sonuc = from gecici in veriTabani.AdminTbl
                        where gecici.AdmiKullaniciAdi == admin.AdmiKullaniciAdi
                       && gecici.AdminSifre == admin.AdminSifre
                        select gecici;
         
            if (sonuc.Any())
            {
                OnayForm onayformu = new OnayForm();
                onayformu.Show();
            }
            else
            {
                MessageBox.Show("Hatali giris yaptınız");
            }
        }

    }

    }

