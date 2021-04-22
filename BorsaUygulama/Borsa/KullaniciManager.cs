using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
   public class KullaniciManager
    {
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();


        public Boolean KullaniciEkle(KullaniciTbl kullanici)
        {

            if (KullaniciAdKontrol(kullanici) == true)
            {
                veriTabani.KullaniciTbl.Add(kullanici);
                veriTabani.SaveChanges();
                MessageBox.Show("kullanici eklendi");
                return true;
            }
            return false;

        }
        public Boolean KullaniciAdKontrol(KullaniciTbl kullanici)
        {
            return true;
        }
    }
}
