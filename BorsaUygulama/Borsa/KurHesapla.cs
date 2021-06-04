using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; //xml kullanmak icin gerekli kutuphane

namespace Borsa
{
    class KurHesapla
    {
       public decimal KurBilgisiGetir(string paratipi)
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";//sitenin adresini verdik 
            XmlDocument xmldoc = new XmlDocument(); //xmldocument kutuphanesinden bir dosya olusturduk
            xmldoc.Load(bugun);//xmldoc nesnesine merkez bankasinin bilgilerini yukledik
            
            //merkez bankası dolar alis kurunu alindi
            string usd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml.Replace('.', ',');//noktayı virgüle ceviriyoruz hesaplama yaparken binlik olarak algılıyor

            //merkez bankası euro alis kuru alindi
            string euro = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml.Replace('.', ',');

            //merkez bankası pound alis kuru alindi
            string pound = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteBuying").InnerXml.Replace('.',',');
            
            
            if (paratipi == "Euro") //para tipi euro ise euro kur bilgisi gonderilir
            {
                return Convert.ToDecimal(euro);
                
            }
            else if (paratipi == "Dolar")
            {
                return Convert.ToDecimal(usd);
            }
            else if (paratipi == "Pound")
            {Console.WriteLine(pound);
                return Convert.ToDecimal(pound) ;
            }
            else return 0;
        }
    }
}
