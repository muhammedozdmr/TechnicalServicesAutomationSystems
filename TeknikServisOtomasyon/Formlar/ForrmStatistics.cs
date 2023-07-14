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
            lblUrunSayisi.Text = db.TBLURUNs.Count().ToString();
            lblKategoriSayisi.Text = db.TBLKATEGORIs.Count().ToString();
            lblStokSayisi.Text = db.TBLURUNs.Sum(x=>x.STOK).ToString();
            lblEnFazlaStokluUrun.Text = (from x in db.TBLURUNs
                                         orderby x.STOK descending
                                         select x.AD).FirstOrDefault();
            lblEnAzStokluUrun.Text = (from x in db.TBLURUNs orderby x.STOK ascending select x.AD).FirstOrDefault();
            lblEnYuksekFiyatliUrun.Text = (from x in db.TBLURUNs orderby x.SATISFIYAT descending select x.AD).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = (from x in db.TBLURUNs orderby x.SATISFIYAT ascending select x.AD).FirstOrDefault();
            lblKritikSeviye.Text = "10";
            lblBeyazStokSayisi.Text = db.TBLURUNs.Count(x => x.KATEGORI == 4).ToString();
            lblBilgisayarStokSayisi.Text = db.TBLURUNs.Count(x => x.KATEGORI == 1).ToString();
            lblKucukEvAlet.Text = db.TBLURUNs.Count(x => x.KATEGORI == 3).ToString();
            lblMarkaSayisi.Text = (from x in db.TBLURUNs select x.MARKA).Distinct().Count().ToString();


        }
    }
}
