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
    public partial class FrmUrunIslemleri : Form
    {
        public Form geriDonulecekForm;
        public FrmUrunIslemleri(Form donulecekForm)
        {
            InitializeComponent();
            geriDonulecekForm = donulecekForm;
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            // Kategoriler combox listeleme işlemi
            var kategoriler = (from x in db.TBL_KATEGORI 
                               select new 
                               { 
                                   x.ID,
                                   x.AD 
                               }
                               ).ToList();

            cbKategori.ValueMember = "ID";
            cbKategori.DisplayMember = "AD";
            cbKategori.DataSource = kategoriler;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBL_URUN select new
            {
                x.URUNID,
                ÜRÜN = x.URUNAD,
                x.MARKA,
                x.STOK,
                FİYAT = x.FIYAT,
                KATEGORİ = x.TBL_KATEGORI.AD,
                x.DURUM
            }
            ).ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBL_URUN urunler = new TBL_URUN();
            urunler.URUNAD = tbUrunAd.Text;
            urunler.MARKA = tbMarka.Text;
            urunler.STOK = short.Parse(tbStokSayisi.Text);
            urunler.FIYAT = decimal.Parse(tbFiyat.Text);
            urunler.DURUM = true;
            urunler.KATEGORI = int.Parse(cbKategori.SelectedValue.ToString());

            db.TBL_URUN.Add(urunler);
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbId.Text);
            var urun = db.TBL_URUN.Find(id);
            db.TBL_URUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbId.Text);
            var urun = db.TBL_URUN.Find(id);
            urun.URUNAD = tbUrunAd.Text;
            urun.MARKA = tbMarka.Text;
            urun.STOK = short.Parse(tbStokSayisi.Text);
            urun.FIYAT = decimal.Parse(tbFiyat.Text);
            urun.DURUM = bool.Parse(tbDurum.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün güncellendi");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tbId.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            tbUrunAd.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            tbMarka.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            tbStokSayisi.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(); tbFiyat.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            cbKategori.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            tbDurum.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbId.Clear();
            tbUrunAd.Clear();
            tbMarka.Clear();
            tbStokSayisi.Clear();
            tbFiyat.Clear();
            tbDurum.Clear();
        }

        private void FrmUrunIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            geriDonulecekForm.Show();
        }
    }
}
