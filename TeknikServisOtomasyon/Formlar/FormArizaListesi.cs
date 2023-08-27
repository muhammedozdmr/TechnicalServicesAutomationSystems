using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormArizaListesi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=OZDEMIR;Initial Catalog=DbTeknikServis;Integrated Security=True");
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormArizaListesi()
        {
            InitializeComponent();
        }
        private void FormArizaListesi_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT URUNDURUMDETAY, COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", conn);
            SqlDataReader dr = command.ExecuteReader();
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARI = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            conn.Close();
            gridList.DataSource = degerler.ToList();
            lblMevcutAriza.Text = db.TBLURUNKABUL.Where(x => x.URUNDURUM == true).Count().ToString();
            lblTadilatiBitmis.Text = db.TBLURUNKABUL.Where(x => x.URUNDURUM == false).Count().ToString();
            lblToplamUrun.Text = db.TBLURUN.Count().ToString();
            lblParcaBekleyen.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            lblMesajBeklenen.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            lblIptalEdilen.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormArizaDetaylar arizaDetaylar = new FormArizaDetaylar();
            arizaDetaylar.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            arizaDetaylar.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            arizaDetaylar.Show();
        }
    }
}
