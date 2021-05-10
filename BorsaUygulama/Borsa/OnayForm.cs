using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
    public partial class OnayForm : Form
    {
        public OnayForm()
        {
            InitializeComponent();
        }
        private VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        private OnayIslemleriManager onayIslemleri = new OnayIslemleriManager();
        public void TabloyuGoster()
        {
            //onay tablosu ve kullanici tablosundaki bilgiler birlestirilerek grdOnayTablosu'na getirildi.
            var sorgu = from onay in veriTabani.OnayTbl
                        join kullanici in veriTabani.KullaniciTbl
                        on onay.KullaniciID equals kullanici.KullaniciId //Onay tablosundaki kullaniciId si ve Kullanici tablosundaki kullaniciId si eşit olmalı
                        select new
                        {
                            //Tablonun sutun isimleri ile getirilecek veriler ayarlandi ve listeye atildi.
                            OnayId = onay.OnayId,
                            KullaniciId = kullanici.KullaniciId,
                            Kullanici = kullanici.KullaniciAd + " " + kullanici.KullaniciSoyad,
                            Tc = kullanici.KullaniciTc,
                            Onaylanacak_Nesne = onay.OnaylanacakNesne,
                            Onaylanacak_Miktar = onay.Miktar
                        };

            grdOnayTablosu.DataSource = sorgu.ToList(); //Olusan liste grdOnayTablosu'na kaynak olarak verildi.
            if (!sorgu.Any()) //listede hic eleman yoksa butonlar kapatılır 
            {
                btnReddet.Enabled = false;
                btnOnayla.Enabled = false;
                MessageBox.Show("Güzel Haber Yapılacak Bir İs Yok");
            }

        }
        private void OnayForm_Load(object sender, EventArgs e)
        {
            TabloyuGoster(); // Form ilk acildiginda bekleyen onaylar grdOnayTablosu'nda gosterilir.          
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            //Onay Tablosunda bulunan istekler onaylanır.
            var sorgu = veriTabani.OnayTbl.Find(grdOnayTablosu.SelectedRows[0].Cells[0].Value); //Onaylanacak veri bulunur.
            onayIslemleri.Onaylama(sorgu); //Bulunan veri onayIslemleri formundaki onaylama metoduna gonderilerek onaylama islemi gerceklestirilir.         
            OnaySil(); //Onaylanan istek silinir.
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            //Reddedilen istek direkt tablodan silinir ve mesaj ekrana yazilir.
            OnaySil();
            MessageBox.Show("Seçilen İşlem Reddedilmiştir!");
        }

        private void OnaySil()
        {
            var sorgu = veriTabani.OnayTbl.Find(grdOnayTablosu.SelectedRows[0].Cells[0].Value); //Tablodan onayId'sine gore veriyi bulur
            veriTabani.OnayTbl.Remove(sorgu);//Bulunan veri silinir.
            veriTabani.SaveChanges(); //Degisiklikler veritabanina kaydedilir.
            TabloyuGoster();//Tablonun son guncel hali gosterilir.
        }

        private void formuKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formuKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
