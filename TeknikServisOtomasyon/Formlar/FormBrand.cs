using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormBrand : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=OZDEMIR;Initial Catalog=DbTeknikServis;Integrated Security=True");
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormBrand()
        {
            InitializeComponent();
        }

        private void FormBrand_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridBrandList.DataSource = degerler.ToList();
            lblMarkaSayisi.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            lblUrunSayisi.Text = db.TBLURUN.Count().ToString();
            lblEnYuksekFiyatMarka.Text = (from x in db.TBLURUN orderby x.SATISFIYAT descending select x.MARKA).FirstOrDefault();
            //SQL Procedure
            lblEnFazlaUrunMarka.Text = db.maksUrunMarka().FirstOrDefault();

            conn.Open();
            SqlCommand command = new SqlCommand("SELECT MARKA, COUNT(*) FROM TBLURUN GROUP BY MARKA", conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            conn.Close();

            //chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Beko", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 7);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 2);
            //chartControl1.Series["Series 1"].Points.AddPoint("Apple", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bosch", 1);

            conn.Open();
            SqlCommand command2 = new SqlCommand("SELECT TBLKATEGORI.AD,COUNT (TBLURUN.AD) AS ADET FROM TBLURUN INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID = TBLURUN.KATEGORI GROUP BY TBLKATEGORI.AD", conn);
            SqlDataReader dr2 = command.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            conn.Close();

            //chartControl2.Series["Series 1"].Points.AddPoint("Beyaz Eşya", 4);
            //chartControl2.Series["Series 1"].Points.AddPoint("Bilgisayar", 6);
            //chartControl2.Series["Series 1"].Points.AddPoint("Küçük Ev Aletleri", 3);
            //chartControl2.Series["Series 1"].Points.AddPoint("TV", 2);
            //chartControl2.Series["Series 1"].Points.AddPoint("Telefon", 8);
            //chartControl2.Series["Series 1"].Points.AddPoint("Diğer", 2);
        }
    }
}
