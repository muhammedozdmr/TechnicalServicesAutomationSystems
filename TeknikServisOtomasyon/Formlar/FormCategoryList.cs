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
    public partial class FormCategoryList : Form
    {
        public FormCategoryList()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FormCategoryList_Load(object sender, EventArgs e)
        {
            FormList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLKATEGORI category = new TBLKATEGORI();
            category.AD = txtCategoryName.Text;
            db.TBLKATEGORIs.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori kaydedildi.");
            FormList();
        }
        private void FormList()
        {
            var degerler = from k in db.TBLKATEGORIs
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridCategoryList.DataSource = degerler.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FormList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtCategoryID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtCategoryName.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryID.Text);
            var deger = db.TBLKATEGORIs.Find(id);
            db.TBLKATEGORIs.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FormList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryID.Text);
            var deger = db.TBLKATEGORIs.Find(id);
            deger.AD = txtCategoryName.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormList();
        }
    }
}
