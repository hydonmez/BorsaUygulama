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

            if (urunuBul(satilacakUrun)>= miktar)
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
                MessageBox.Show("eklenemedi");
            }
        }
       
        public int urunuBul(string alinacakUrun)
        {
            int adet = 0;
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == GirisIslemleriManager.girisId select gecici;
            foreach (var item in sorgu)
            {
                string deger = "Hesaptaki" + alinacakUrun;
                var x= item.GetType().GetProperty(deger).GetValue(item, null);
                return Convert.ToInt32(x);
            }

            return 0;
        }



    }
}
