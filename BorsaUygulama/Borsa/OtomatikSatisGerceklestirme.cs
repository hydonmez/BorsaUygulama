using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borsa
{
   public class OtomatikSatisGerceklestirme
    {
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        KullaniciTbl kullaniciAlici = new KullaniciTbl ();
        KullaniciTbl kullaniciSatici = new KullaniciTbl();
        
        
        public List<AliciIstekTbl> AlicilariBul(string satilanUrun)
        {
           var sorgu = from gecici in veriTabani.AliciIstekTbl where gecici.IstenilenUrun == satilanUrun orderby gecici.IstekTarihi select gecici;
            return (List<AliciIstekTbl>)sorgu;
          
        }

        public List<SatistakiUrunTbl> SaticilariBul(string alinacakUrun)
        {
            var sorgu = from gecici in veriTabani.SatistakiUrunTbl where gecici.SatistakiNesne == alinacakUrun 
                        orderby gecici.SatistakiFiyati, gecici.SatisIstekTarihi select gecici;
            return (List<SatistakiUrunTbl>)sorgu;
        }

        public void satisYap(string satilacakUrun)
        {
            foreach (var item in AlicilariBul(satilacakUrun))
            {
                
                foreach (var item2 in SaticilariBul(item.IstenilenUrun))
                {


                }
            }

        }
        public void Alis(string alinacakurun,decimal alınacamiktar)
        {
            var sorgu = from gecici in veriTabani.SatistakiUrunTbl where gecici.SatistakiNesne == alinacakurun orderby gecici.SatistakiMiktari select gecici;
            foreach (var item in sorgu)
            {

                
            }
        }
        public void alisislemigercekleştir()
        {
            
        }
        public Boolean kontrolet()
        {
            return true;
        }

        
    }
}
