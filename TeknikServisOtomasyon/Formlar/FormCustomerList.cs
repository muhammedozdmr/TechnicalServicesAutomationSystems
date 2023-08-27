using DevExpress.Skins.XtraForm;
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
    public partial class lblEnFazlaCariIL : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public lblEnFazlaCariIL()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridList.DataSource = (from x in db.TBLCARI
                                   select new
                                   {
                                       x.ID,
                                       ADSOYAD = x.AD + " " + x.SOYAD,
                                       x.MAIL,
                                       x.IL,
                                       x.ILCE
                                   }).ToList();
            lblCariSayisi.Text = db.TBLCARI.Count().ToString();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.il_no,
                                                     x.isim
                                                 }).ToList();
            lblToplamIL.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            lblIlceSayisi.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
        }
        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from x in db.TBLILCELER
                                                 select new
                                                 {
                                                     x.ilce_no,
                                                     x.isim,
                                                     x.il_no
                                                 }).Where(y=> y.il_no == secilen).ToList();  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtName.Text;
            t.SOYAD = txtSoyad.Text;
            t.IL = lookUpEdit1.Text;
            t.ILCE = lookUpEdit2.Text;
            t.ADRES = txtAdres.Text;
            t.BANKA = txtBanka.Text;
            t.TELEFON = txtTelefon.Text;
            t.STATU = txtStatu.Text;
            t.VERGIDAIRESI = txtVergiDairesi.Text;
            t.VERGINO = txtvergiNo.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Cari sisteme eklendi !");
            Listele();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
