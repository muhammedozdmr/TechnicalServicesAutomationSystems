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
    public partial class FormArizaliUrunDetayListesi : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1 ();
        public FormArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }

        private void gridList_Click(object sender, EventArgs e)
        {
            gridList.DataSource = (from x in db.TBLURUNTAKIPs
                                   select new
                                   {
                                       x.TAKIPID,
                                       x.SERINO,
                                       x.TARIH,
                                       x.ACIKLAMA
                                   }).ToList();
        }
    }
}
