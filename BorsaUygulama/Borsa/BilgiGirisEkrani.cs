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
    public partial class BilgiGirisEkrani : Form
    {
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
     
        public BilgiGirisEkrani()
        {
            InitializeComponent();
        }
        
        private void BilgiGirisEkrani_Load(object sender, EventArgs e)
        {
   
            var sorgu = from gecici in veriTabani.KullaniciTbl where gecici.KullaniciId == GirisIslemleriManager.girisId select gecici;
            dataGridView1.DataSource = sorgu.ToList() ;
                       
        }

        private void btnİstek_Click(object sender, EventArgs e)
        {

            OnayTbl onaylanacak = new OnayTbl();
            onaylanacak.KullaniciID = GirisIslemleriManager.girisId;
            onaylanacak.OnaylanacakNesne = cmbİstek.Text;
            onaylanacak.Miktar =Convert.ToInt32 (txtMiktar.Text);
            veriTabani.OnayTbl.Add(onaylanacak);
            veriTabani.SaveChanges();
            MessageBox.Show("onaylandı");
        }
    }
}
