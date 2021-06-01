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
            string usd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml;
            
            //merkez bankası euro alis kuru alindi
            string euro = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
            
            //merkez bankası pound alis kuru alindi
            string pound = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteBuying").InnerXml;
            
            if (paratipi == "Euro") //para tipi euro ise euro kur bilgisi gonderilir
            {
                return Convert.ToDecimal(euro) / 10000;//10.434 geldigi icin veri mecburan 10,434 çevirmek için 10000'ne bölüyoruz
            }
            else if (paratipi == "Dolar")
            {
                return Convert.ToDecimal(usd) / 10000;
            }
            else if (paratipi == "Pound")
            {
                return Convert.ToDecimal(pound) / 10000;
            }
            else return 0;
        }
    }
}
