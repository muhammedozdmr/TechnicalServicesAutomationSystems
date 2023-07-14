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
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FormProductList_Load(object sender, EventArgs e)
        {
            //Listeleme
            FormListRefresh();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            TBLURUN tableProduct = new TBLURUN();
            tableProduct.AD = txtProductName.Text;
            tableProduct.MARKA = txtProductMark.Text;
            tableProduct.ALISFIYAT = decimal.Parse(txtBuyPrice.Text);
            tableProduct.SATISFIYAT = decimal.Parse(txtSellPrice.Text);
            tableProduct.STOK = short.Parse(txtStock.Text);
            tableProduct.DURUM = false;
            tableProduct.KATEGORI = byte.Parse(cmbCategory.EditValue.ToString());
            db.TBLURUNs.Add(tableProduct);
            db.SaveChanges();
            MessageBox.Show("Ürün kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            FormListRefresh();
        }
        private void GetListCategory()
        {
            var products = from u in db.TBLURUNs
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.TBLKATEGORI.AD,
                               u.ALISFIYAT,
                               u.SATISFIYAT,
                               u.STOK
                           };
            gridProductList.DataSource = products.ToList();
        }
        private void FormListRefresh()
        {
            //hepsi gelir
            //var products = db.TBLURUNs.ToList();
            GetListCategory();
            cmbCategory.Properties.DataSource = db.TBLKATEGORIs.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtProductID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtProductName.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtProductMark.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtBuyPrice.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtSellPrice.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStock.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductID.Text);
            var deger = db.TBLURUNs.Find(id);
            db.TBLURUNs.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            FormListRefresh();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductID.Text);
            var deger = db.TBLURUNs.Find(id);
            deger.AD = txtProductName.Text;
            deger.MARKA = txtProductMark.Text;
            deger.STOK = short.Parse(txtStock.Text);
            deger.ALISFIYAT = decimal.Parse(txtBuyPrice.Text);
            deger.SATISFIYAT = decimal.Parse(txtSellPrice.Text);
            deger.KATEGORI = byte.Parse(cmbCategory.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormListRefresh();

        }
    }
}