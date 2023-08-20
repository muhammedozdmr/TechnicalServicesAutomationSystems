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
            t.URUN = int.Parse(txtID.Text);
            t.MUSTERI = int.Parse(txtCustomer.Text);
            t.PERSONEL = short.Parse(txtPersonel.Text);
            t.TARIH = DateTime.Parse(txtDate.Text);
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
    }
}
