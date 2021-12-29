# Borsa Uygulaması

## Proje Ekip Üyeleri:

* Tuba AKBAŞ                212802004
* Hüseyin Yasin DÖNMEZ      202802003


## Proje Açıklaması:

Bu proje satıcıları ve alıcıları bir araya getirerek. Bir borsa mantığında pazar oluşturulmasını sağlar alıcılar belirlediği fiyati geçmemek şartıyla en düşük fiyattan istedikleri ürünleri alırken satıcılarda ürünlerini satabilmektedir.Aynı zamanda alıcıların aldığı ürünler ve satıcıların sattiği ürünler istenirse kullanıcılar tarafından excel formatında belli tarihler arasında rapor alabilme imkanı sunmaktadır. Proje merkez bankası döviz kurlarından(pound,usd,euro)parabirimlerinin verilerini çekerek admin onay esnasındaki döviz kurları üzerinden kullaniciların onaya sundukları döviz türünden paraları tl olarak hesaplarına yatmaktadır.Projede alıcı taraftan %1 olarak komisyon kesilerek şirketin hesabına yatırılmaktadır.Proje tüm alış ve satiş bilgilerini veritabanına kaydetmektedir.

## Projenin  Çalıştırılması

Projeyi çalıştırabilmek için proje klasöründe bulunan
VeriTabani.bacpac dosyasını microsoft sql server programınıza aktarmanız gerekmektedir
proje dosyaları içinde bulunan VeriTabani.edmx kısmını ve app config dosyasını visual studiodan silerek 
proje üzerinde sağ tıklayıp ekle>yenioge>data(veri)>ADO.net entity data model seçilerek veritabanı sisteme eklenir ve çalışmaya hazırdır
