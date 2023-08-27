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
    public partial class FormProductSale : Form
    {
        public FormProductSale()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN = int.Parse(cmbId.EditValue.ToString());
            t.MUSTERI = int.Parse(cmbCari.EditValue.ToString());
            t.PERSONEL = short.Parse(cmbPersonel.EditValue.ToString());
            t.TARIH = dateCreate.Value;
            t.ADET = short.Parse(txtCount.Text);
            t.FIYAT = decimal.Parse(txtSellPrice.Text);
            t.URUNSERINO = textSerialNO.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı");
        }
        private void CloseForm()
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void FormProductSale_Load(object sender, EventArgs e)
        {
            cmbId.Properties.DataSource = (from x in db.TBLURUN
                                           select new
                                           {
                                               x.ID,
                                               x.AD
                                           }).ToList();
            cmbCari.Properties.DataSource = (from x in db.TBLCARI
                                             select new
                                             {
                                                 x.ID,
                                                 ADSOYAD = x.AD + " " + x.SOYAD
                                             }).ToList();
            cmbPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     ADSOYAD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void txtCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = string.Empty;
        }

        private void txtSellPrice_Click(object sender, EventArgs e)
        {
            txtSellPrice.Text = string.Empty;
        }

        private void textSerialNO_Click(object sender, EventArgs e)
        {
            textSerialNO.Text = string.Empty;
        }
    }
}
