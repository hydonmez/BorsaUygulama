using System;
using System.Collections.Generic;
using System.Linq;
using excel = Microsoft.Office.Interop.Excel;//excelde islem yapmak icin gerekli 221 satır
using Application = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;

namespace Borsa
{
    class RaporOlusturmaManager
    {
        public RaporOlusturmaManager()
        {

        }
        VeriTabaniEntities veriTabani = new VeriTabaniEntities(); //veritabanina erismek icin bir nesnesi yaratılır 
        public void RaporOlustur(DateTime baslangictarihi, DateTime bitistarihi) //rapor oolusturan metottur giren kullanicinin ıdsine ve parametre olarak gonderilen baslangic ve bitis tarihleri  arasinda alis ve satis rapor olusturur
        {
            Application Rapor = new excel.Application(); //yeni bir excel uygulamasi acilir 
            Workbook kitap = Rapor.Workbooks.Add(System.Reflection.Missing.Value);// yeni bir kitap olsuturuyoruz
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];//sayfa olusturuluyor 1.sayfa olusturduk 




            Range alan = (Range)sayfa.Cells[1, 1];



            //sutun adları belirlenir
            alan.Cells[1, 1] = "  SATİS TARİHİNİZ  "; //a1

            alan.Cells[1, 2] = "  SATİLAN URUNUNUZ  ";//b1

            alan.Cells[1, 3] = "  SATİS MİKTARİNİZ  ";//c1

            alan.Cells[1, 4] = "  SATİS FİYATİNİZ  ";//d1

            alan.Cells[1, 5] = "   SATİS TOPLAM KAZANCİNİZ   ";//e1

            alan.Cells[1, 6] = "|";
            alan.Cells[1, 7] = "           ";
            alan.Cells[1, 8] = "|";
            alan.Cells[1, 9] = "ALİS TARİHİNİZ";
            alan.Cells[1, 10] = "ALİNAN URUN";
            alan.Cells[1, 11] = "ALİS MİKTARİNİZ";
            alan.Cells[1, 12] = "ALİS FİYATİNİZ";
            alan.Cells[1, 13] = "ALİS VERGİSİ";
            alan.Cells[1, 14] = "TOPLAM HARCAMANİZ";


            int i = 2;//1. satirda sutun isimleri oldugu için i hep 2 den baslamalidir



            foreach (var item in SatisBilgisiniGetir(baslangictarihi, bitistarihi)) //satisbilgileri listesinden donulur listedeki her bir kayıt satiri excellde bir satira yazılır
            {
                alan.Cells[i, 1] = item.SatisTarihi;
                alan.Cells[i, 2] = item.SatilanUrun;
                alan.Cells[i, 3] = item.SatisMiktari;
                alan.Cells[i, 4] = item.SatisFiyati;
                alan.Cells[i, 5] = item.ToplamKazanc;
                alan.Cells[i, 6] = "|";



                i++;//excelde bir sonraki satıra geçmek için

            }



            i = 2; //i tekrar 2 ye esitlenir 1. satirda sutun isimleri vardir
            foreach (var item in AlisBilgisiniiGetir(baslangictarihi, bitistarihi)) //alisbilgilerri listesinde donulur listedeki her bir kayit satiri excelde bir satira yazilir
            {
                alan.Cells[i, 8] = "|";//karirisikligi engellemek icin bir isaret

                alan.Cells[i, 9] = item.AlisTarihi;
                alan.Cells[i, 10] = item.AlınanUrun;
                alan.Cells[i, 11] = item.AlisMiktari;
                alan.Cells[i, 12] = item.AlisFiyati;
                alan.Cells[i, 13] = item.AlistakiVergi;
                alan.Cells[i, 14] = item.ToplamHarcama;
                i++;

            }
            sayfa.Rows.AutoFit();//sayfanın satirlari otomatik boyut olacak sekilde ayarlanir 
            sayfa.Columns.AutoFit();//sayfanin sutunlari otomatik boyut olacak sekilde ayarlanir 
            Rapor.Visible = true; //olusturulan rapor kullaniciya gosterilir 

        }
        private List<AliciLog> AlisBilgisiniiGetir(DateTime baslangictarihi, DateTime bitistarihi) // istenilen tarihler arasındaki alis bilgileri alistarihlerine gore artan siralamada getirilir
        {
           

            var alislariniz = from alislar in veriTabani.AliciLog where alislar.KullaniciId == KullaniciGirisIslemleriManager.g_girisId && alislar.AlisTarihi >= baslangictarihi && alislar.AlisTarihi <= bitistarihi orderby alislar.AlisTarihi descending select alislar;

            return alislariniz.ToList();//gelen kayitlar liste halinde geri donulur 



      
        }

        private List<SatisLog> SatisBilgisiniGetir(DateTime baslangictarihi, DateTime bitistarihi) // istenilen tarihler arasındaki satis bilgileri alistarihlerine gore artan siralamada getirilir 
        {


            var satislariniz = from satislar in veriTabani.SatisLog where satislar.KullaniciId == KullaniciGirisIslemleriManager.g_girisId && satislar.SatisTarihi >= baslangictarihi && satislar.SatisTarihi <= bitistarihi orderby satislar.SatisTarihi descending select satislar;

            return satislariniz.ToList();//gelen kayitlar liste halinde geri donulur 
        }


    }

}



