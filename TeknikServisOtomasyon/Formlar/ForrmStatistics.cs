using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class ForrmStatistics : Form
    {
        public ForrmStatistics()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void ForrmStatistics_Load(object sender, EventArgs e)
        {
            lblUrunSayisi.Text = db.TBLURUN.Count().ToString();
            lblKategoriSayisi.Text = db.TBLKATEGORI.Count().ToString();
            lblStokSayisi.Text = db.TBLURUN.Sum(x=>x.STOK).ToString();
            lblEnFazlaStokluUrun.Text = (from x in db.TBLURUN
                                         orderby x.STOK descending
                                         select x.AD).FirstOrDefault();
            lblEnAzStokluUrun.Text = (from x in db.TBLURUN orderby x.STOK ascending select x.AD).FirstOrDefault();
            lblEnYuksekFiyatliUrun.Text = (from x in db.TBLURUN orderby x.SATISFIYAT descending select x.AD).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = (from x in db.TBLURUN orderby x.SATISFIYAT ascending select x.AD).FirstOrDefault();
            lblKritikSeviye.Text = "10";
            lblBeyazStokSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            lblBilgisayarStokSayisi.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            lblKucukEvAlet.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            lblMarkaSayisi.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            lblArizaliUrunSayisi.Text=db.TBLURUNKABUL.Count().ToString();
            lblEnFazlaUrunMarka.Text = db.maksKategori().FirstOrDefault();


            /*
             tadilatı bitmiş ürün
             kargodaki ürün sayısı
             en fazla ürün kategorisi
             beyaz eşya stok sayısı
             bugün satılan
             tamirdeki ürün sayısı
             bugün getirilen ürün
             */

        }
    }
}
