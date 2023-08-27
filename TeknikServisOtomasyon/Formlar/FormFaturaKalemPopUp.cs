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
    public partial class FormFaturaKalemPopUp : Form
    {
        public FormFaturaKalemPopUp()
        {
            InitializeComponent();
        }
        public int id;
        private void FormFaturaKalemPopUp_Load(object sender, EventArgs e)
        {
           DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            gridControl1.DataSource = (from x in db.TBLFATURADETAY select new
            {
                x.FATURAID,
                x.URUN,
                x.ADET,
                x.FIYAT,
                x.TUTAR
            }).Where(x=>x.FATURAID==id.ToString()).ToList();
            gridControl2.DataSource = db.TBLFATURABILGI.Where(x=>x.ID == id).ToList();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.pdf";
            gridControl1.ExportToPdf(path);
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.xlsx";
            gridControl1.ExportToXlsx(path);
        }
    }
}
