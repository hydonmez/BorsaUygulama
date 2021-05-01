using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa
{
    public class AlisIslemleriManager
    {
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();



        public void AlisIstegiGonder(string alinacakUrun,int miktar)
        {
            if (ParaYeterliMi())
            {


                AliciIstekTbl aliciistek = new AliciIstekTbl();
                aliciistek.AliciIstekId = GirisIslemleriManager.girisId;
                aliciistek.IstenilenUrun = alinacakUrun;
                aliciistek.IstekMiktari = miktar;
                aliciistek.IstekTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                veriTabani.AliciIstekTbl.Add(aliciistek);
                veriTabani.SaveChanges();
                MessageBox.Show("Alis isteginiz alinmistir ");
            }
            else
            {
                MessageBox.Show("Hesabınızda para bulumamaktadır");
            }
        }
        public Boolean ParaYeterliMi()
        {
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == GirisIslemleriManager.girisId select gecici;
            foreach (var item in sorgu)
            {
                if (item.HesaptakiPara > 0)
                {
                    return true;
                }
            }
            return false;


        }
    }
}
