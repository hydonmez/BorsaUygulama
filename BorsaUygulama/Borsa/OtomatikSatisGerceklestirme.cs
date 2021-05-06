using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Borsa
{
    public class OtomatikSatisGerceklestirme
    {
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
       


        public List<AliciIstekTbl> AlicilariBul(string satilanUrun)
        {
            var sorgu = from gecici in veriTabani.AliciIstekTbl where gecici.IstenilenUrun == satilanUrun orderby gecici.IstekTarihi select gecici;
            
            return sorgu.ToList();

        }

        public List<SatistakiUrunTbl> SaticilariBul(string alinacakUrun)
        {
            var sorgu = from gecici in veriTabani.SatistakiUrunTbl
                        where gecici.SatistakiNesne == alinacakUrun
                        orderby gecici.SatistakiFiyati, gecici.SatisIstekTarihi
                        select gecici;
            return sorgu.ToList();
        }

        public void satisYap(string satilacakUrun)
        {
           


            foreach (var alici in AlicilariBul(satilacakUrun))
            {
            
                decimal alicininparasi = alicininParasınıGetir(alici.KullaniciId);

                foreach (var satici in SaticilariBul(alici.IstenilenUrun))
                {
                    int alicininaldigiurun = 0;
                    decimal saticininkazandigipara = 0;

                   while (satici.SatistakiMiktari != 0 && alici.IstekMiktari != 0 && Convert.ToDecimal(alicininparasi) >= Convert.ToDecimal(satici.SatistakiFiyati))
                    {

                        alicininaldigiurun++;
                        saticininkazandigipara += satici.SatistakiFiyati;
                        satici.SatistakiMiktari -= 1;
                        alici.IstekMiktari -= 1;
                        alicininparasi -= Convert.ToDecimal(satici.SatistakiFiyati);

                    }
                    if (satici.SatistakiMiktari == 0) //ilk saticinin tüm ürünleri satıldıysa tablodan sil
                    {
                        
                        var sorgu = veriTabani.SatistakiUrunTbl.Find(satici.SatisId);
                        if (sorgu != null)
                        {
                            veriTabani.SatistakiUrunTbl.Remove(sorgu);
                            veriTabani.SaveChanges();
                        }
                    
                    }
                    if (alici.IstekMiktari == 0)
                    {
                       
                        var sorgu = veriTabani.AliciIstekTbl.Find(alici.AliciIstekId); //istek sıfırlandıysa tabloyu sil 
                        if (sorgu != null)
                        {
                            veriTabani.AliciIstekTbl.Remove(sorgu);
                            veriTabani.SaveChanges();
                        }
                        
                      
                    }
        
                        var saticininhesabi2 = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == satici.KullaniciId select gecici;
                        foreach (var item in saticininhesabi2)
                        {
                            string deger = "Hesaptaki" + satilacakUrun;
                            var x = Convert.ToDecimal(item.GetType().GetProperty(deger).GetValue(item, null));
                            x -= alicininaldigiurun;
                            item.GetType().GetProperty(deger).SetValue(item, x);//aldigi urunu hesabına ekledik 
                            item.HesaptakiPara += saticininkazandigipara;
                          
                        }
                        var alicininhesabi2 = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == alici.KullaniciId select gecici;
                        {
                            foreach (var item2 in alicininhesabi2)
                            {
                                item2.HesaptakiPara -= saticininkazandigipara; //saticiya verdiği parayı hesabından çıkardık;
                                string deger = "Hesaptaki" + satilacakUrun;
                                var x = Convert.ToDecimal(item2.GetType().GetProperty(deger).GetValue(item2, null));
                                x += alicininaldigiurun;
                                item2.GetType().GetProperty(deger).SetValue(item2, x);//aldigi urunu hesabına ekledik                                                       
                            }
                        veriTabani.SaveChanges();
                    }

                    

                }
            }

        }
        public void Alis(string alinacakurun, decimal alınacamiktar)
        {
            var sorgu = from gecici in veriTabani.SatistakiUrunTbl where gecici.SatistakiNesne == alinacakurun orderby gecici.SatistakiMiktari select gecici;
            foreach (var item in sorgu)
            {


            }
        }
        public decimal alicininParasınıGetir(int kullaniciID)
        {
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == kullaniciID select gecici;
            foreach (var item in sorgu)
            {
                return Convert.ToDecimal(item.HesaptakiPara);
            }
            return 0;
        }
        public Boolean kontrolet()
        {
            return true;
        }


    }
}
