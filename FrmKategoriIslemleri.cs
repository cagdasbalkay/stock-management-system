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
    public partial class FrmKategoriIslemleri : Form
    {
        public Form geriDonulecekPencere;
        public FrmKategoriIslemleri(Form donulecekPencere)
        {
            InitializeComponent();
            geriDonulecekPencere = donulecekPencere;
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_KATEGORI.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBL_KATEGORI ktg = new TBL_KATEGORI();
            ktg.AD = tbKategoriAd.Text;
            db.TBL_KATEGORI.Add(ktg);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbKategoriId.Text);
            var ktg = db.TBL_KATEGORI.Find(id);
            db.TBL_KATEGORI.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Kategori silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbKategoriId.Text);
            var ktg = db.TBL_KATEGORI.Find(id);
            ktg.AD = tbKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori güncellendi");
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tbKategoriId.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            tbKategoriAd.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void FrmKategoriIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            geriDonulecekPencere.Show();
        }
    }
}
