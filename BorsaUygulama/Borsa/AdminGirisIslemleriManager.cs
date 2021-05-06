using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
   public class AdminGirisIslemleriManager
    {
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();//veritabaniyla ilgili islemleri yapabilmek icin nesne olusturuldu
        public void GirisYap(AdminTbl admin)//Parametre olarak admin nesnesi aliyoruz. 
        {   
            //Parametre olarak gelen nesne ile veritabaninda bulunan AdminTbl deki eşleşen veriyi listeye atar.
            var sonuc = from gecici in veriTabani.AdminTbl 
                        where gecici.AdmiKullaniciAdi == admin.AdmiKullaniciAdi
                        && gecici.AdminSifre == admin.AdminSifre select gecici;

            if (sonuc.Any()) //Liste bos degilse yani kullanici bulunduysa onay formu acilir
            {
                OnayForm onayFormu = new OnayForm(); //Formunu acmak icin OnayForm sinifinin nesnesini yarattik
                onayFormu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }
    }
}
