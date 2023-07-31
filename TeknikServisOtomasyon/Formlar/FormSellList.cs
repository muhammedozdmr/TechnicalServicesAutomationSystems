using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormSellList : Form
    {
        public FormSellList()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FormSellList_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNHAREKETs
                           select new
                           {
                               x.HAREKETID,
                               x.TBLURUN.AD,
                               MUSTERI = x.TBLCARI.AD +" "+ x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD +" "+ x.TBLPERSONEL.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.URUNSERINO
                           };
            gridList.DataSource = degerler.ToList();
        }
    }
}
