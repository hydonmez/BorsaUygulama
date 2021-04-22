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
        private void OnayForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veriTabani.OnayTbl.ToList();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
           //datagridwiew seçtiğin id git değiştirilecek urun neyse onu+
        }
    }
}
