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
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormCreateProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            urun.KATEGORI = byte.Parse(cmbDropdown.EditValue.ToString());
            db.TBLURUN.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıylka kaydedildi");
        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            txtProductName.Text = string.Empty;
            txtProductName.Focus();
        }

        private void FormCreateProduct_Load(object sender, EventArgs e)
        {
            cmbDropdown.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }
    }
}
