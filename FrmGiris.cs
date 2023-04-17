using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrunProje
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();

            var sorgu = from x in db.TBL_ADMIN where x.Kullanici == textBox1.Text && x.Sifre == textBox2.Text select x;

            if(sorgu.Any())
            {
                FrmAnaForm fr = new FrmAnaForm(this);
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş bilgileri hatalı !");
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void linkCikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
