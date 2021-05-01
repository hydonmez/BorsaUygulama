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
        VeriTabaniEntities veriTabani = new VeriTabaniEntities();
        OnayTbl onaylama = new OnayTbl();
        OnayIslemleriManager onayislemleri = new OnayIslemleriManager();
        
        private void OnayForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veriTabani.OnayTbl.ToList();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            var sorgu = veriTabani.OnayTbl.Find(dataGridView1.SelectedRows[0].Cells[0].Value);
            onayislemleri.onaylama(sorgu);
            OnaySil();
            }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            OnaySil();
            MessageBox.Show("Seçilen islem red edilmistir");
        }

        public void OnaySil()
        {
            var sorgu = veriTabani.OnayTbl.Find(dataGridView1.SelectedRows[0].Cells[0].Value);
            veriTabani.OnayTbl.Remove(sorgu);
            veriTabani.SaveChanges();
            dataGridView1.DataSource = veriTabani.OnayTbl.ToList();
            
        }
    }
}
