using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.İletişim
{
    public partial class FormRehber : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1 ();
        public FormRehber()
        {
            InitializeComponent();
        }

        private void FormRehber_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.ID,
                                           ADSOYAD = x.AD + " " + x.SOYAD,
                                           x.TELEFON,
                                           x.MAIL,
                                           x.IL,
                                           x.ILCE
                                       }).ToList();
        }
    }
}
