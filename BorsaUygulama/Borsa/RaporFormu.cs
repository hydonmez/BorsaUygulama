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
    public partial class RaporFormu : Form
    {
        public RaporFormu()
        {
            InitializeComponent();
        }
        private void btnRaporAl_Click(object sender, EventArgs e) //rapol alma işlemlerini gerçekleştirir
        {

            RaporOlusturmaManager raporIslemleri = new RaporOlusturmaManager();// raporalmak için raporislemleri sınıfından bir nesne türetilir
            raporIslemleri.RaporOlustur(dtpBaslangicTarihi.Value, dtpBitisTarihi.Value);//raporolustur fonksiyonunu baslangic ve bitis tarihleri parametre olarak gönderilr
        }

        private void formuKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void formuKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
