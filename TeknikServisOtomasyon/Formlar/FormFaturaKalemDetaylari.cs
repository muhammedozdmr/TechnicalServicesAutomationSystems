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
    public partial class FormFaturaKalemDetaylari : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1 ();
        public FormFaturaKalemDetaylari()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFaturaId.Text);
            var degerler = (from u in db.TBLFATURADETAYs
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           }).Where(x=>x.FATURADETAYID == id).ToList();
            gridList.DataSource = degerler.ToList();
        }
    }
}
