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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();

            label2.Text = db.TBL_KATEGORI.Count().ToString();
            label3.Text = db.TBL_URUN.Count().ToString();

            label5.Text = db.TBL_MUSTERI.Count
            (x => x.DURUM == true).ToString();

            label7.Text = db.TBL_MUSTERI.Count
            (x => x.DURUM == false).ToString();

            label15.Text = db.TBL_URUN.Count
                (x => x.KATEGORI == 1).ToString();

            label13.Text = db.TBL_URUN.Sum
            (y => y.STOK).ToString();

            label11.Text = (from x in db.TBL_URUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();

            label9.Text = (from x in db.TBL_URUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();

            label23.Text = (from x in db.TBL_MUSTERI select x.SEHIR).Distinct().Count().ToString();

            label21.Text = db.TBL_SATIS.Sum
                (x => x.FIYAT).ToString() + " TL";

            label19.Text = db.MARKAGETIR().FirstOrDefault();

            label17.Text = db.TBL_URUN.Count
             (x => x.URUNAD == "BUZDOLABI").ToString();


        }
    }
}
