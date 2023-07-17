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
    public partial class FormBrand : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormBrand()
        {
            InitializeComponent();
        }

        private void FormBrand_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUNs.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridBrandList.DataSource = degerler.ToList();
            lblMarkaSayisi.Text = (from x in db.TBLURUNs select x.MARKA).Distinct().Count().ToString();
            lblUrunSayisi.Text = db.TBLURUNs.Count().ToString();
            lblEnYuksekFiyatMarka.Text = (from x in db.TBLURUNs orderby x.SATISFIYAT descending select x.MARKA).FirstOrDefault();
            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 7);
            chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 2);
            chartControl1.Series["Series 1"].Points.AddPoint("Apple", 5);
            chartControl1.Series["Series 1"].Points.AddPoint("Bosch", 1);

            chartControl2.Series["Series 1"].Points.AddPoint("Beyaz Eşya", 4);
            chartControl2.Series["Series 1"].Points.AddPoint("Bilgisayar", 6);
            chartControl2.Series["Series 1"].Points.AddPoint("Küçük Ev Aletleri", 3);
            chartControl2.Series["Series 1"].Points.AddPoint("TV", 2);
            chartControl2.Series["Series 1"].Points.AddPoint("Telefon", 8);
            chartControl2.Series["Series 1"].Points.AddPoint("Diğer", 2);
        }
    }
}
