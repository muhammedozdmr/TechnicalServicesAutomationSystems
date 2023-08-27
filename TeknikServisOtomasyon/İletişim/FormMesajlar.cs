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
    public partial class FormMesajlar : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormMesajlar()
        {
            InitializeComponent();
        }

        private void FormMesajlar_Load(object sender, EventArgs e)
        {
            lblToplamMesajSayisi.Text = db.TBLILETISIM.Count().ToString();
            lblTesekkur.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            lblRica.Text = db.TBLILETISIM.Where(x => x.KONU == "Rica").Count().ToString();
            lblSikayet.Text = db.TBLILETISIM.Where(x => x.KONU == "Şikayet").Count().ToString();
            gridList.DataSource = (from x in db.TBLILETISIM
                                   select new
                                   {
                                       x.MAIL,
                                       x.ADSOYAD,
                                       x.KONU,
                                       x.MESAJ
                                   }).ToList();
        }
    }
}
