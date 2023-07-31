using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormArizaListesi : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormArizaListesi()
        {
            InitializeComponent();
        }
        private void FormArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABULs
                           select new
                           {
                               x.ISLEMID,
                               CARI = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO
                           };
            gridList.DataSource = degerler.ToList();
        }
    }
}
