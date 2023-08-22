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
    public partial class FormHomePage : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1 ();
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x=>x.STOK < 30).ToList();
            gridControl2.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.AD,
                                           x.SOYAD,
                                           x.IL
                                       }).ToList();

            //procedure
            gridControl3.DataSource = db.urunkategori().ToList();
            DateTime today = DateTime.Today;
            var sonuc = (from x in db.TBLNOTLARIM.OrderBy(x => x.ID).Where(x => x.TARIH == today)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         }).ToList();
            gridControl4.DataSource = sonuc;

            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5;
            konu1 = db.TBLILETISIM.First(x=>x.ID == 1).KONU;
            ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = konu1 + " - " + ad1;

            konu2 = db.TBLILETISIM.First(x => x.ID == 2).KONU;
            ad2 = db.TBLILETISIM.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = konu2 + " - " + ad2;
        }
    }
}
