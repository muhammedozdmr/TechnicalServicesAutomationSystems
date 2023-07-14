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
    public partial class FormCreateProduct : Form
    {
        public FormCreateProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormCreateProduct form = new FormCreateProduct();
            form.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            TBLURUN urun = new TBLURUN();
            urun.AD = txtProductName.Text;
            urun.MARKA = txtBrand.Text;
            urun.SATISFIYAT = decimal.Parse(txtSellPrice.Text);
            urun.ALISFIYAT = decimal.Parse(txtBuyPrice.Text);
            urun.STOK = short.Parse(txtStock.Text);
            urun.KATEGORI = byte.Parse(txtCategory.Text);
            db.TBLURUNs.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıylka kaydedildi");
        }
    }
}
