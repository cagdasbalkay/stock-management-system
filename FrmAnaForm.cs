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
    public partial class FrmAnaForm : Form
    {
        public Form geriDonulecekPencere;
        public FrmAnaForm(Form donulecekPencere)
        {
            InitializeComponent();
            geriDonulecekPencere = donulecekPencere;
        }

        private void btnKategoriIslemleri_Click(object sender, EventArgs e)
        {
            FrmKategoriIslemleri fr = new FrmKategoriIslemleri(this);
            fr.Show();
            this.Hide();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            FrmUrunIslemleri fr = new FrmUrunIslemleri(this);
            fr.Show();
            this.Hide();
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
        }

        private void FrmAnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            geriDonulecekPencere.Show();
        }
    }
}
